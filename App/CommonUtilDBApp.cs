using System;
using System.Collections.Generic;
using System.Text;
using Repository.Domain;
using Repository.Interface;

namespace App
{
    public class CommonUtilDbApp : BaseApp<UserRole>
    {
        public CommonUtilDbApp(IUnitWork unitWork, IRepository<UserRole> repository) : base(unitWork, repository)
        {
        }
    }
}
