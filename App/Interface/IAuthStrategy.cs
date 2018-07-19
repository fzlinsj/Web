using System;
using System.Collections.Generic;
using System.Text;
using App.Response;
using Repository.Domain;

namespace App.Interface
{
    public interface IAuthStrategy
    {
        List<ModuleView> Modules { get; }

        List<RoleInfo> Roles { get; }

        List<Resource> Resources { get; }

        List<Company> Orgs { get; }

        UserInfo User
        {
            get; set;
        }

    }
}
