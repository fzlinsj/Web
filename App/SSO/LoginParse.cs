using System;
using Infrastructure.Cache;
using Microsoft.AspNetCore.Http;
using Repository.Domain;
using Repository.Interface;

namespace App.SSO
{
    public class LoginParse
    {

        //这个地方使用IRepository<User> 而不使用UserManagerApp是防止循环依赖
        public IRepository<UserInfo> _app;
        private ICacheContext _cacheContext;
        private AppInfoService _appInfoService;

        public LoginParse(AppInfoService infoService, ICacheContext cacheContext, IRepository<UserInfo> userApp)
        {
            _appInfoService = infoService;
            _cacheContext = cacheContext;
            _app = userApp;
        }

        public LoginResult Do(PassportLoginRequest model)
        {
            var result = new LoginResult();
            try
            {

                // 验证码对错验证
               

                //if (!checkCodeInput.Equals(checkCode))
                //{
                //    ////设置报错消息param
                //    //string[] param = { "验证码" };
                //    //SetError(userID, context.Response, "txtCheckCode", "Common", "E003", "验证码错误");
                //    //return;
                //}




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
