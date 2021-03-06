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
    public partial class AttendanceReportMonth : Entity
    {
        public AttendanceReportMonth()
        {
          this.ReprotNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.AttendanceType= string.Empty;
          this.ChangeType= string.Empty;
          this.ChangeNote= string.Empty;
          this.ChangeDate= DateTime.Now;
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
	    /// 员工ID
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AttendanceType { get; set; }
        /// <summary>
	    /// 应出勤时间
	    /// </summary>
        public decimal? Hours { get; set; }
        /// <summary>
	    /// 实际出勤时间
	    /// </summary>
        public decimal? WorkHour { get; set; }
        /// <summary>
	    /// 加班（时）
	    /// </summary>
        public decimal? Overtime { get; set; }
        /// <summary>
	    /// 请假（时）
	    /// </summary>
        public decimal? Leave { get; set; }
        /// <summary>
	    /// 外出
	    /// </summary>
        public decimal? Out { get; set; }
        /// <summary>
	    /// 出差（天）
	    /// </summary>
        public decimal? Business { get; set; }
        /// <summary>
	    /// 替班（时）
	    /// </summary>
        public decimal? Instead { get; set; }
        /// <summary>
	    /// 调休（时）
	    /// </summary>
        public decimal? Transferred { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Late { get; set; }
        /// <summary>
	    /// 迟到分钟数
	    /// </summary>
        public decimal? LateMinute { get; set; }
        /// <summary>
	    /// 早退（天）
	    /// </summary>
        public decimal? LeaveEarly { get; set; }
        /// <summary>
	    /// 早退分钟数
	    /// </summary>
        public decimal? LeaveEarlyMinute { get; set; }
        /// <summary>
	    /// 旷工（天）
	    /// </summary>
        public decimal? Absence { get; set; }
        /// <summary>
	    /// 出勤率
	    /// </summary>
        public decimal? AttendanceRate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ChangeTimes { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ChangeType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ChangeNote { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Changer { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ChangeDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? NomalHour { get; set; }

    }
}