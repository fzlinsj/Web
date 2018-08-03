using System;
using System.Collections.Generic;
using System.Text;
using App.AuthStrategies;
using App.Interface;
using Repository.Domain;
using Repository.Interface;

namespace App
{
    /// <summary>
    ///  加载用户所有可访问的资源/机构/模块
    /// <para>李玉宝新增于2016-07-19 10:53:30</para>
    /// </summary>
    public class AuthContextFactory
    {
        private SystemAuthStrategy _systemAuth;
        private NormalAuthStrategy _normalAuthStrategy;
        private readonly IUnitWork _unitWork;
        private CommonUtilDbApp CommonUtil;

        public AuthContextFactory(SystemAuthStrategy sysStrategy, NormalAuthStrategy normalAuthStrategy, IUnitWork unitWork, CommonUtilDbApp commonUtil)
        {
            _systemAuth = sysStrategy;
            _normalAuthStrategy = normalAuthStrategy;
            _unitWork = unitWork;
            CommonUtil = commonUtil;
        }

        public AuthStrategyContext GetAuthStrategyContext(string username)
        {
            IAuthStrategy service = null;
            if (username == "System")
            {
                service = _systemAuth;
            }
            else
            {
                service = _normalAuthStrategy;
                service.User = _unitWork.FindSingle<UserInfo>(u => u.Id == username);
            }

            return new AuthStrategyContext(service) { CommonUtil = CommonUtil};
        }
    }
}
