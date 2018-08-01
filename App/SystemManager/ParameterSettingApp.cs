using Infrastructure;
using Repository.Domain;
using Repository.Interface;
using System;
using System.Data;
using System.Linq;

namespace App.SystemManager
{
    public class ParameterSettingApp : BaseApp<ParameterSetting>
    {
        public ParameterSettingApp(IUnitWork unitWork, IRepository<ParameterSetting> repository) : base(unitWork, repository)
        {
        }

        #region 读取参数配置
        public  DataTable Get(string companyCd, string functionType)
        {
            var dtRole = CommonHelper.ToDataTable(Repository.Find(u => u.CompanyCD == companyCd && u.FunctionType == Convert.ToInt32(functionType)).ToList());

            return dtRole;
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="companyCd"></param>
        /// <param name="functionType"></param>
        /// <param name="isUsing"></param>
        /// <returns></returns>
        public bool Get(string companyCd, string functionType, bool isUsing)
        {
            var dt =Get(companyCd, functionType);

            if (dt == null || dt.Rows.Count <= 0)
            {
                return isUsing;
            }
            else
            {
                return dt.Rows[0]["UsedStatus"].ToString() == "1";
            }
        }

        public DataTable GetPoint(string companyCd, string functionType)
        {
            var dt =Get(companyCd, functionType);

            if (dt == null || dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }

        #endregion



    }
}
