using System;
using System.Collections.Generic;
using System.Text;
using App.Interface;
using App.Response;
using Repository.Domain;
using Repository.Interface;

namespace App.AuthStrategies
{
    public class NormalAuthStrategy : BaseApp<UserInfo>, IAuthStrategy
    {
        public NormalAuthStrategy(IUnitWork unitWork, IRepository<UserInfo> repository) : base(unitWork, repository)
        {
        }

        public List<ModuleView> Modules { get; set; }
        public List<RoleInfo> Roles { get; }
        public List<Resource> Resources { get; }
        public List<Company> Orgs { get; }
        public UserInfo User { get; set; }
      
    }
}
