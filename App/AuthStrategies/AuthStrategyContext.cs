using System;
using System.Collections.Generic;
using System.Text;
using App.Interface;
using App.Response;
using Repository.Domain;

namespace App.AuthStrategies
{
    /// <summary>
    ///  授权策略上下文，一个典型的策略模式
    /// </summary>
    public class AuthStrategyContext
    {
        private readonly IAuthStrategy _strategy;
        public AuthStrategyContext(IAuthStrategy strategy)
        {
            this._strategy = strategy;
        }

        public UserInfo User
        {
            get { return _strategy.User; }
        }

        public List<ModuleView> Modules
        {
            get
            {
                if(CommonUtil!=null)
                {

                    _strategy.Modules=CommonUtil.GetMenuData(User.Id, User.CompanyCD);

                }

                return _strategy.Modules;
            }
        }

        public List<RoleInfo> Roles
        {
            get { return _strategy.Roles; }
        }

        public List<Resource> Resources
        {
            get { return _strategy.Resources; }
        }

        public List<Company> Orgs
        {
            get { return _strategy.Orgs; }
        }

        public CommonUtilDbApp CommonUtil { get; set; }

    }
}
