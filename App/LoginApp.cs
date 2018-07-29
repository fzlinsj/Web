using System.Linq;
using App.Response;
using Repository.Domain;
using Repository.Interface;

namespace App
{
    public class LoginApp: BaseApp<UserInfo>
    {
        public LoginApp(IUnitWork unitWork, IRepository<UserInfo> repository) : base(unitWork, repository)
        {
        }

        public TableData GetUserInfoByUserId(string userId)
        {

            var result = new TableData();

            var query = from A in UnitWork.Find<UserInfo>(u => u.Id.Equals(userId))
                join C in UnitWork.Find<EmployeeInfo>(null) on A.EmployeeID equals C.Id
                join D in UnitWork.Find<DeptInfo>(null) on C.DeptID equals D.Id
                join E in UnitWork.Find<DeptQuarter>(null) on C.QuarterID equals E.Id
                join B in UnitWork.Find<CompanyOpenServ>(null) on A.CompanyCD equals B.Id
                select new
                {
                    UserName=string.IsNullOrEmpty(C.EmployeeName)?A.IsRoot.Equals("1")? "系统管理员":"": C.EmployeeName,
                    A.IsRoot,
                    IsHardValidate= string.IsNullOrEmpty(A.IsHardValidate)?"1": A.IsHardValidate,
                    A.Password,
                    A.EmployeeID,
                    A.LockFlag,
                    A.LastLoginTime,
                    CompanyCD=B.Id,
                    EnableUSBKEYLOGIN=B.EnableUSBKEYLOGIN,
                    CompanyOpenDate=B.OpenDate,
                    CompanyCloseDate=B.CloseDate,
                    UserOpenDate=A.OpenDate,
                    UserCloseDate=A.CloseDate,
                    DeptID =C.DeptID,
                    EmployeeNum=C.EmployeeNum,
                    EmployeeName=C.EmployeeName,
                    QuarterID=string.IsNullOrEmpty(C.QuarterID)?"":C.QuarterID,
                    DeptName= string.IsNullOrEmpty(D.DeptName)?"":D.DeptName,


                };

            result.data = query.FirstOrDefault();
            result.count = 1;

            return result;

        }
    }
}
