using System.Data;
using Repository.Domain;
using Repository.Interface;
using System.Linq;
using Infrastructure;

namespace App
{
    public class CommonUtilDbApp : BaseApp<UserRole>
    {
        public CommonUtilDbApp(IUnitWork unitWork, IRepository<UserRole> repository) : base(unitWork, repository)
        {
        }

        /// <summary>
        /// 获得用户可操作菜单数据
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="companyCd">公司代码</param>
        /// <returns>返回用户可操作的菜单集。</returns>
        public DataTable GetMenuData(string userId, string companyCd,bool isFilter)
        {

            var roleFunctions = UnitWork.Find<RoleFunction>(null);

            if (isFilter)
            {
                roleFunctions = roleFunctions.Where(u => u.ModuleID.Length <= 2);
            }
            var query = from B in UnitWork.Find<UserRole>(u => u.UserID.Equals(userId))
                join C in roleFunctions on B.RoleID equals C.RoleID
                join D in UnitWork.Find<CompanyModule>(null) on new{C.ModuleID, C.CompanyCD } equals new{D.ModuleID,D.CompanyCD}
                join E in UnitWork.Find<SysModule>(null) on D.ModuleID equals E.Id
                select new
                {

                    ModuleID=E.Id,
                    E.ModuleName,
                    E.ModuleType,
                    E.ParentID,
                    E.PropertyType,
                    E.PropertyValue,
                    E.ImgPath,
                    E.DefaultPage
                };

            return CommonHelper.ToDataTable(query.OrderBy(u => u.ModuleID).ToList());

        }
    }
}
