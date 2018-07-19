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
    public partial class AttendanceReport : Entity
    {
        public AttendanceReport()
        {
          this.ReprotNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.ReportName= string.Empty;
          this.Month= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.CreateUserID= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Status= string.Empty;
          this.ReportURL= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 报表编号
	    /// </summary>
        public string ReprotNo { get; set; }
        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 报表名称
	    /// </summary>
        public string ReportName { get; set; }
        /// <summary>
	    /// 所属月份
	    /// </summary>
        public string Month { get; set; }
        /// <summary>
	    /// 考核开始时间
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 考核结束时间
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 编制人ID
	    /// </summary>
        public string CreateUserID { get; set; }
        /// <summary>
	    /// 编制日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 状态(0草稿，1提交)
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 报表文件URL
	    /// </summary>
        public string ReportURL { get; set; }
        /// <summary>
	    /// 最后更新时间
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}