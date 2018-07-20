using System;
using Infrastructure.Cache;
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
