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
    public partial class AttendanceApply : Entity
    {
        public AttendanceApply()
        {
          this.CompanyCD= string.Empty;
          this.ApplyNo= string.Empty;
          this.EmployeeID= 0;
          this.Flag= string.Empty;
          this.ApplyDate= DateTime.Now;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.StartTime= string.Empty;
          this.EndTime= string.Empty;
          this.FactStartDate= DateTime.Now;
          this.FactEndDate= DateTime.Now;
          this.FactStartTime= DateTime.Now;
          this.FactEndTime= DateTime.Now;
          this.ApplyReason= string.Empty;
          this.BusinessDate= DateTime.Now;
          this.BusinessPlanDate= DateTime.Now;
          this.BusinessPlace= string.Empty;
          this.BusinessPeer= string.Empty;
          this.BusinessTransport= string.Empty;
          this.BusinessRemark= string.Empty;
          this.OvertimeType= string.Empty;
          this.InsteaEmployees= string.Empty;
          this.InsteadEmployees= string.Empty;
          this.InsteadStartTime= string.Empty;
          this.InsteadEndTime= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ApplyNo { get; set; }
        /// <summary>
	    /// 员工ID
	    /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
	    /// 区分(1请假，2加班，3外出，4出差，5替班)
	    /// </summary>
        public string Flag { get; set; }
        /// <summary>
	    /// 申请时间
	    /// </summary>
        public System.DateTime ApplyDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ApplyUserID { get; set; }
        /// <summary>
	    /// 考勤开始日期
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 考勤结束日期
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 开始时间
	    /// </summary>
        public string StartTime { get; set; }
        /// <summary>
	    /// 结束时间
	    /// </summary>
        public string EndTime { get; set; }
        /// <summary>
	    /// 实际开始日期
	    /// </summary>
        public System.DateTime? FactStartDate { get; set; }
        /// <summary>
	    /// 实际结束日期
	    /// </summary>
        public System.DateTime? FactEndDate { get; set; }
        /// <summary>
	    /// 实际开始时间
	    /// </summary>
        public System.DateTime? FactStartTime { get; set; }
        /// <summary>
	    /// 实际结束时间
	    /// </summary>
        public System.DateTime? FactEndTime { get; set; }
        /// <summary>
	    /// 申请事由
	    /// </summary>
        public string ApplyReason { get; set; }
        /// <summary>
	    /// 请假类别
	    /// </summary>
        public int? LeaveType { get; set; }
        /// <summary>
	    /// 出差时间
	    /// </summary>
        public System.DateTime? BusinessDate { get; set; }
        /// <summary>
	    /// 预计时间
	    /// </summary>
        public System.DateTime? BusinessPlanDate { get; set; }
        /// <summary>
	    /// 地点（出差或外出）
	    /// </summary>
        public string BusinessPlace { get; set; }
        /// <summary>
	    /// 出差通行人
	    /// </summary>
        public string BusinessPeer { get; set; }
        /// <summary>
	    /// 出差交通工具
	    /// </summary>
        public string BusinessTransport { get; set; }
        /// <summary>
	    /// 出差预借费用
	    /// </summary>
        public decimal? BusinessAdvance { get; set; }
        /// <summary>
	    /// 出差备注
	    /// </summary>
        public string BusinessRemark { get; set; }
        /// <summary>
	    /// 加班事由
	    /// </summary>
        public string OvertimeType { get; set; }
        /// <summary>
	    /// 加班工时
	    /// </summary>
        public decimal? OvertimeHours { get; set; }
        /// <summary>
	    /// 替班人
	    /// </summary>
        public string InsteaEmployees { get; set; }
        /// <summary>
	    /// 被替班人
	    /// </summary>
        public string InsteadEmployees { get; set; }
        /// <summary>
	    /// 被替开始时间
	    /// </summary>
        public string InsteadStartTime { get; set; }
        /// <summary>
	    /// 被替结束时间
	    /// </summary>
        public string InsteadEndTime { get; set; }
        /// <summary>
	    /// 最后更新时间
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户id
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}