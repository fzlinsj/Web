﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Repository.Core;

namespace Repository.Domain
{
    /// <summary>
	/// 
	/// </summary>
    public partial class PerformanceTemplateEmp : Entity
    {
        public PerformanceTemplateEmp()
        {
          this.CompanyCD= string.Empty;
          this.TemplateNo= string.Empty;
          this.StepName= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 模板编号
	    /// </summary>
        public string TemplateNo { get; set; }
        /// <summary>
	    /// 被考核人（对应员工表ID）
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 步骤顺序
	    /// </summary>
        public int? StepNo { get; set; }
        /// <summary>
	    /// 步骤名称（如：初评，复评）
	    /// </summary>
        public string StepName { get; set; }
        /// <summary>
	    /// 考核得分权重
	    /// </summary>
        public decimal? Rate { get; set; }
        /// <summary>
	    /// 考核打分人员（对应员工表ID）
	    /// </summary>
        public int? ScoreEmployee { get; set; }
        /// <summary>
	    /// 描述信息
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}