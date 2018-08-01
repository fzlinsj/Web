using System;
using System.Collections.Generic;
using System.Text;
using Repository.Domain;
using Repository.Interface;

namespace App.SystemManager
{
    public class CompanyApp : BaseApp<Company>
    {
        public CompanyApp(IUnitWork unitWork, IRepository<Company> repository) : base(unitWork, repository)
        {
        }
    }
}
