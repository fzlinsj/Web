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
    public partial class PersonalDateArrange : Entity
    {
        public PersonalDateArrange()
        {
          this.CompanyCD= string.Empty;
          this.ArrangeTItle= string.Empty;
          this.Critical= string.Empty;
          this.ArrangPerson= string.Empty;
          this.Content= string.Empty;
          this.StartDate= DateTime.Now;
          this.StartTime= string.Empty;
          this.EndTime= string.Empty;
          this.IsPublic= string.Empty;
          this.CreateDate= DateTime.Now;
          this.IsMobileNotice= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Important= string.Empty;
          this.EndDate= DateTime.Now;
          this.ManagerNote= string.Empty;
          this.ManagerDate= DateTime.Now;
          this.CanViewUser= string.Empty;
          this.CanViewUserName= string.Empty;
          this.Status= string.Empty;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 安排主题
	    /// </summary>
        public string ArrangeTItle { get; set; }
        /// <summary>
	    /// 紧急程度(1宽松,2一般,3较急,4紧急,5特急)
	    /// </summary>
        public string Critical { get; set; }
        /// <summary>
	    /// 保留
	    /// </summary>
        public string ArrangPerson { get; set; }
        /// <summary>
	    /// 日程内容
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 日程日期
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 开始时间（时分）
	    /// </summary>
        public string StartTime { get; set; }
        /// <summary>
	    /// 结束时间（时分）
	    /// </summary>
        public string EndTime { get; set; }
        /// <summary>
	    /// 日程安排人ID(对应员工表ID)
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 保密度（0不公开，1公开）
	    /// </summary>
        public string IsPublic { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 是否手机短信提醒（0否，1是）
	    /// </summary>
        public string IsMobileNotice { get; set; }
        /// <summary>
	    /// 提前时间（小时）
	    /// </summary>
        public int? AheadTimes { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID（对应操作用户表中的UserID）
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 重要程度(1不重要,2普通,3重要,4关键)
	    /// </summary>
        public string Important { get; set; }
        /// <summary>
	    /// 结束日期
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 点评人ID
	    /// </summary>
        public int? ToManagerID { get; set; }
        /// <summary>
	    /// 点评内容
	    /// </summary>
        public string ManagerNote { get; set; }
        /// <summary>
	    /// 点评日期
	    /// </summary>
        public System.DateTime? ManagerDate { get; set; }
        /// <summary>
	    /// 可查看人员ID
	    /// </summary>
        public string CanViewUser { get; set; }
        /// <summary>
	    /// 可查看人员姓名
	    /// </summary>
        public string CanViewUserName { get; set; }
        /// <summary>
	    /// 日程状态（0草稿，1提交,2已点评）
	    /// </summary>
        public string Status { get; set; }

    }
}