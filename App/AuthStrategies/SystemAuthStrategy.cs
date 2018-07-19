using System;
using System.Collections.Generic;
using System.Text;
using App.Interface;
using App.Response;
using Repository;
using Repository.Domain;
using Repository.Interface;

namespace App.AuthStrategies
{
    /// <summary>
    /// 领域服务
    /// <para>超级管理员权限</para>
    /// <para>超级管理员使用guid.empty为ID，可以根据需要修改</para>
    /// </summary>
    public class SystemAuthStrategy : BaseApp<UserInfo>, IAuthStrategy
    {
        public SystemAuthStrategy(IUnitWork unitWork, IRepository<UserInfo> repository) : base(unitWork, repository)
        {
        }


        public List<ModuleView> Modules { get; }
        public List<RoleInfo> Roles { get; }
        public List<Resource> Resources { get; }
        public List<Company> Orgs { get; }
        public UserInfo User { get; set; }
    }
}
