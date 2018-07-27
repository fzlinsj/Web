using System;
using System.Linq;
using Infrastructure;
using Infrastructure.Cache;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Repository;
using Repository.Domain;
using Repository.Interface;

namespace App.SSO
{
    public class LoginParse
    {

        //这个地方使用IRepository<User> 而不使用UserManagerApp是防止循环依赖
        //public IRepository<UserInfo> _app;
        public LoginApp _loginApp;
        private ICacheContext _cacheContext;
        private AppInfoService _appInfoService;
        private IOptions<AppSetting> _options;
        private IHttpContextAccessor _httpContextAccessor;

        public LoginParse(AppInfoService infoService, ICacheContext cacheContext, IOptions<AppSetting> options, IHttpContextAccessor httpContextAccessor,LoginApp app)
        {
            _appInfoService = infoService;
            _cacheContext = cacheContext;
            //_app = userApp;
            _options = options;
            _httpContextAccessor = httpContextAccessor;
            _loginApp = app;
        }

        public LoginResult Do(PassportLoginRequest model)
        {
            var result = new LoginResult();

            try
            {

                // 验证码对错验证

                //var ip = _httpContextAccessor.HttpContext.Request.HttpContext.Connection.LocalIpAddress.MapToIPv4().ToString();

                //var userAgent = _httpContextAccessor.HttpContext.Request.Headers["HeaderUserAgent"];

                //if (ip != "" && userAgent != "")
                //{

                //}


                //if (!checkCodeInput.Equals(checkCode))
                //{
                //    ////设置报错消息param
                //    //string[] param = { "验证码" };
                //    //SetError(userID, context.Response, "txtCheckCode", "Common", "E003", "验证码错误");
                //    //return;
                //}



                var data=_loginApp.GetUserInfoByUserId("yangyang");

                Console.WriteLine(JsonHelper.Instance.Serialize(data));

                //var categories = _app.FindSingle<UserInfo>(null);


                //var userInfo = _app.FindSingle(u => u.Id == model.Account);


                //var query = from category in categories
                //    join ct in UnitWork.Find<CategoryType>(null) on category.TypeId equals ct.Id
                //        into tmp
                //    from ct in tmp.DefaultIfEmpty()
                //    select new
                //    {
                //        category.Name,
                //        category.Id,
                //        category.TypeId,
                //        TypeName = ct.Name,
                //        category.Description
                //    };




            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
