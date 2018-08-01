using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using App.SystemManager;
using Infrastructure;
using Infrastructure.Cache;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Repository.Domain;
using Repository.Interface;

namespace App.SSO
{
    public class LoginParse
    {

        //这个地方使用IRepository<User> 而不使用UserManagerApp是防止循环依赖
        public IRepository<UserRole> _appUserRole;
        public IRepository<Company> _companyApp;
        public LoginApp _loginApp;
        public CommonUtilDbApp _commonApp;
        private ICacheContext _cacheContext;
        private AppInfoService _appInfoService;
        private IOptions<AppSetting> _options;
        private IHttpContextAccessor _httpContextAccessor;
        private ParameterSettingApp _parameterSettingApp;
        private IRepository<UserInfo> _userInfoApp;


        /// <summary>
        /// 用户已经登陆标志
        /// </summary>
        private const string HAD_LOGIN = "1";
        /// <summary>
        /// 用户被锁标志
        /// </summary>
        private const string HAD_LOCKED = "1";

        public LoginParse(AppInfoService infoService, ICacheContext cacheContext, IOptions<AppSetting> options, 
            IHttpContextAccessor httpContextAccessor,LoginApp app, IRepository<UserRole> userRoleApp, 
            CommonUtilDbApp commonApp, IRepository<Company> companyApp,ParameterSettingApp parameterSettingApp, IRepository<UserInfo> userInfo)
        {
            _appInfoService = infoService;
            _cacheContext = cacheContext;
            _appUserRole = userRoleApp;
            _options = options;
            _httpContextAccessor = httpContextAccessor;
            _loginApp = app;
            _commonApp = commonApp;
            _companyApp = companyApp;
            _parameterSettingApp = parameterSettingApp;
            _userInfoApp = userInfo;
        }

        #region 获取部门角色信息

        /// <summary>
        /// 获取部门角色信息
        /// </summary>
        /// <param name="userID">用户名</param>
        /// <param name="companyCD">公司代码</param>
        /// <returns>DataTable 部门角色信息</returns>
        public  int[] GetRoleInfo(string userID, string companyCD)
        {
            //定义返回的角色数组
            int[] role = new int[0];

            try
            {
                //获取角色信息
                var roleList = _appUserRole.Find(u => u.UserID == userID && u.CompanyCD == companyCD).ToList();
                DataTable dtRole = CommonHelper.ToDataTable(roleList);
                //当角色存在的时候，设置角色到数组中
                if (dtRole != null && dtRole.Rows.Count > 0)
                {
                    //获取角色个数
                    int roleCount = dtRole.Rows.Count;
                    role = new int[roleCount];
                    //遍历所有角色，并设值
                    for (int i = 0; i < roleCount; i++)
                    {
                        //设置角色
                        role[i] = (int)dtRole.Rows[0]["RoleID"];
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
               
            }
           
            return role;
        }

        #endregion

        public LoginResult Do(PassportLoginRequest model)
        {
            var result = new LoginResult {Code = 500};
            try
            {

               

                //判断是否已经登录
                var userAuthSession = _cacheContext.Get<UserAuthSession>(model.Account);

                if (userAuthSession != null)
                {
                    //设置报错消息
                    SetError(model.Account, ref result, "txtUserID", "Login", "E001", "该用户名已经登陆，不能重复登陆。");

                    return result;

                }

                //Stopwatch watch = new Stopwatch();
                //watch.Start();

                //var testInfo = _userInfoApp.FindSingle(u => u.Id == model.Account);

                //watch.Stop();
                //result.Code = 200;

                //result.Message = string.Format("用时{0}毫秒", watch.ElapsedMilliseconds);

                //return result;

                var data = _loginApp.GetUserInfoByUserId(model.Account);

                //用户名 不存在
                if (data == null || data.data ==null)
                {
                    //设置报错消息
                    SetError(model.Account, ref result, "txtUserID", "Login", "E002", "用户名或密码错误");
                    return result;
                }


                //获取匿名类型的属性值
                var pdc = TypeDescriptor.GetProperties(data.data);
                var pdId = pdc.Find("Password", true);
                string passwordDataBase = pdId.GetValue(data.data);


                //对输入密码进行加密
                string decryptPassword = StringUtil.EncryptPasswordWitdhMD5(model.Password);
                //两密码不同时报错
                if (!decryptPassword.Equals(passwordDataBase))
                {
                    //设置报错消息
                    string[] param = { "密码" };
                    SetError(model.Account, ref result, "txtPassword", "Common", "E003", "用户名或密码错误");
                    return result;
                }


                //UserOpenDate UserCloseDate
                pdId = pdc.Find("UserOpenDate", true);
                DateTime userOpenDate = pdId.GetValue(data.data);
                pdId = pdc.Find("UserCloseDate", true);
                DateTime userCloseDate = pdId.GetValue(data.data);

                if (DateTime.Now < userOpenDate)
                {
                    SetError(model.Account, ref result, "txtPassword", "Common", "E003", "账户未生效");
                    return result;
                }

                if (DateTime.Now > userCloseDate)
                {
                    SetError(model.Account, ref result, "txtPassword", "Common", "E003", "账户已过期");
                    return result;
                }

                //判断是否被锁定
                pdId = pdc.Find("LockFlag", true);
                string lockFlag = pdId.GetValue(data.data);
                if (HAD_LOCKED.Equals(lockFlag))
                {
                    //设置报错消息
                    SetError(model.Account, ref result, "txtUserID", "Login", "E003", "账户被锁定");
                    return result;
                }

                //获得当前时间
                string toDay = DateTime.Now.ToString("yyyyMMdd");

                pdId = pdc.Find("CompanyOpenDate", true);
                //获得用户公司服务开始时间
                string startDate = (string)pdId.GetValue(data.data);
                //获得用户公司服务结束时间
                pdId = pdc.Find("CompanyCloseDate", true);
                string endDate = (string)pdId.GetValue(data.data);
                //当前时间不在公司服务时间范围内时报错
                if (toDay.CompareTo(endDate) > 0 || toDay.CompareTo(startDate) < 0)
                {
                    //设置报错消息
                    string[] param = { "公司" };
                    SetError(model.Account, ref result, "txtUserID", "Login", "E004", "公司不在服务时间");
                    return result;
                }

                //获得用户ID服务开始时间
                startDate = userOpenDate.ToString("yyyyMMdd");
                //获得用户ID服务结束时间
                endDate = userCloseDate.ToString("yyyyMMdd");
                //当前时间不在用户ID服务时间范围内时报错
                if (toDay.CompareTo(endDate) > 0 || toDay.CompareTo(startDate) < 0)
                {
                    //设置报错消息
                    string[] param = { "用户名" };
                    SetError(model.Account, ref result, "txtUserID", "Login", "E004", "用户不在服务时间");
                    return result;
                }

                //获得用户公司代码
                pdId = pdc.Find("CompanyCD", true);
                var companyCD = (string)pdId.GetValue(data.data);
                //获得用户姓名
                pdId = pdc.Find("UserName", true);
                var userName = (string)pdId.GetValue(data.data);
                //获取是否超管信息
                pdId = pdc.Find("IsRoot", true);
                var IsRoot = (string)pdId.GetValue(data.data);

                var role = GetRoleInfo(model.Account, companyCD);

                //只读取顶级菜单信息
                //全部菜单信息放到LEFT.CS内读取并缓存
                //获得用户菜单信息
                var menuInfo = _commonApp.GetMenuData(model.Account, companyCD, true);

                //获得用户页面操作信息
                DataTable authoInfo = null;//SafeUtil.InitPageAuthority(userID, companyCD);

                //设置Session中用户信息
                var userInfo = new UserInfoUtil();

                var companyInfo = _companyApp.FindSingle(u => u.Id == companyCD);

                if (companyInfo != null)
                {
                    userInfo.CompanyName = companyInfo.NameCn;
                }

                //设置用户ID
                userInfo.UserID = model.Account;
                //设置用户姓名
                userInfo.UserName = userName;
                //设置超管信息
                userInfo.IsRoot = IsRoot;
                //设置用户公司代码
                userInfo.CompanyCD = companyCD;

                pdId = pdc.Find("EmployeeID", true);
                //获取人员编号
                string employeeID = (string)pdId.GetValue(data.data);

                //人员ID设置的场合，设置人员ID
                if (!string.IsNullOrEmpty(employeeID))
                {
                    //设置人员ID 
                    userInfo.EmployeeID =employeeID;
                    //设置人员名
                    pdId = pdc.Find("EmployeeName", true);
                    userInfo.EmployeeName = (string)pdId.GetValue(data.data);
                    //设置人员工号
                    pdId = pdc.Find("EmployeeNum", true);
                    userInfo.EmployeeNum = (string)pdId.GetValue(data.data);
                    //获取部门ID
                    pdId = pdc.Find("DeptID", true);
                    string deptID = (string)pdId.GetValue(data.data);
                    //部门ID设置的场合，设置部门ID
                    if (!string.IsNullOrEmpty(deptID))
                    {
                        //设置部门ID
                        userInfo.DeptID =deptID;
                    }
                    //部门名称
                    pdId = pdc.Find("DeptName", true);
                    userInfo.DeptName = (string)pdId.GetValue(data.data);
                }

                //设置角色列表
                userInfo.Role = role;
                //设置用户菜单信息
                userInfo.MenuInfo = menuInfo;
                //设置用户页面操作信息
                userInfo.AuthorityInfo = authoInfo;

                //出入库价格是否显示
                userInfo.IsDisplayPrice = _parameterSettingApp.Get(userInfo.CompanyCD, "1", true);

                //是否启用条码
                userInfo.IsBarCode = _parameterSettingApp.Get(userInfo.CompanyCD, "2", true);

                //是否启用多计量单位
                userInfo.IsMoreUnit = _parameterSettingApp.Get(userInfo.CompanyCD, "3", false);

                //是否启用自动生成凭证
                userInfo.IsVoucher = _parameterSettingApp.Get(userInfo.CompanyCD, "6", false);

                //是否启用自动审核登帐
                userInfo.IsApply = _parameterSettingApp.Get(userInfo.CompanyCD, "7", false);
                //是否启用超订单发货
                userInfo.IsOverOrder = _parameterSettingApp.Get(userInfo.CompanyCD, "8", false);

                //允许出入库价格为零
                userInfo.IsZero = _parameterSettingApp.Get(userInfo.CompanyCD, "9", false);

                //小数位数
                userInfo.SelPoint = "2";//默认 
                var dtPoint = _parameterSettingApp.GetPoint(userInfo.CompanyCD, "5");
                if (dtPoint?.Rows.Count > 0)
                {
                    userInfo.SelPoint = dtPoint.Rows[0]["SelPoint"].ToString();
                }

                //var getUserInfo = _userInfoApp.FindSingle(u => u.CompanyCD == companyCD&&u.Id== model.Account);
                //getUserInfo.LastLoginTime=DateTime.Now;

                _userInfoApp.Update(u => u.CompanyCD == companyCD&& u.Id == model.Account, u => new UserInfo { LastLoginTime = DateTime.Now });


                var currentSession = new UserAuthSession
                {
                    Account = model.Account,
                    Name = userInfo.UserName,
                    Token = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                    AppKey = model.AppKey,
                    CreateTime = DateTime.Now,
                    UserInfo = userInfo
                    //    , IpAddress = HttpContext.Current.Request.UserHostAddress
                };

                //创建Session
                _cacheContext.Set(currentSession.Token, currentSession, DateTime.Now.AddDays(10));

                result.Code = 200;
                result.Token = currentSession.Token;



            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }

            return result;
        }

        #region 设置出错信息

        /// <summary>
        /// 设置出错信息
        /// </summary>
        /// <param name="userID">用户名ID</param>
        /// <param name="response">响应</param>
        /// <param name="cotrolID">控件ID</param>
        /// <param name="moduleID">信息属于模块</param>
        /// <param name="messageID">信息ID</param>
        /// <param name="param">信息中需要的参数</param>
        private void SetError(string userID, ref LoginResult response, string cotrolID, string moduleID, string messageID, string msg)
        {
            //从message文件中读取信息
            //string msg = MessageUtil.GetMessage(moduleID, messageID, param);
            string[] msgs = new string[4];
            msgs[0] = "该户名已经登陆，不能重复登陆。";
            msgs[1] = "该用户名不存在。";
            msgs[2] = "该用户名已被锁定。";
            msgs[3] = "不在服务时间范围内。";

            try
            {
                int msgid = int.Parse(messageID.Substring(messageID.Length - 2, 1)) - 1;
                if (msgid > 0 && msgid < msgs.Length)
                {
                    msg = msgs[msgid];
                }
            }
            catch
            {

            }


            response.Code = 500;
            response.Message = cotrolID + "|" + msg;

            //输出日志
            WriteLog(userID, LogInfo.OperateStatus.FAILED);
        }

        #endregion

        #region 输出日志

        /// <summary>
        /// 输出登陆日志
        /// </summary>
        /// <param name="userID">用户名ID</param>
        /// <param name="status">登陆状态</param>
        private void WriteLog(string userID, LogInfo.OperateStatus status)
        {
            //输出日志
            var log = new LogInfo();
            //用户信息
            var userInfo = new UserInfoUtil {UserID = userID};
            //登陆日志
            log.Type = LogInfo.LogType.LOGIN;
            //登陆
            log.LoginKind = LogInfo.LoginLogKind.LOGIN_LOGIN;
            //用户ID
            log.UserInfo = userInfo;
            //操作状态
            log.Status = status;

            LogUtil.WriteLog(log, _options.Value);
        }

        #endregion
    }
}
