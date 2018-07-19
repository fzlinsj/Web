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
    public partial class PerformancePersonal : Entity
    {
        public PerformancePersonal()
        {
          this.CompanyCD= string.Empty;
          this.TaskNo= string.Empty;
          this.Title= string.Empty;
          this.TaskFlag= string.Empty;
          this.TaskDate= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.WorkContent= string.Empty;
          this.Complete= string.Empty;
          this.AfterWork= string.Empty;
          this.Defects= string.Empty;
          this.Problems= string.Empty;
          this.Advices= string.Empty;
          this.Remark= string.Empty;
          this.Status= string.Empty;
          this.CreateDate= DateTime.Now;
          this.CheckDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 自我鉴定编号
	    /// </summary>
        public string TaskNo { get; set; }
        /// <summary>
	    /// 自我鉴定主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 鉴定周期分类：
	    /// </summary>
        public string TaskFlag { get; set; }
        /// <summary>
	    /// 鉴定年度（对应鉴定周期分类，保存是年份，如2009）
	    /// </summary>
        public string TaskDate { get; set; }
        /// <summary>
	    /// 季/月/周（对应周期分类，例如第1季度）
	    /// </summary>
        public int? TaskNum { get; set; }
        /// <summary>
	    /// 鉴定期间开始日期
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 鉴定期间结束日期
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 工作内容
	    /// </summary>
        public string WorkContent { get; set; }
        /// <summary>
	    /// 完成情况
	    /// </summary>
        public string Complete { get; set; }
        /// <summary>
	    /// 后续工作
	    /// </summary>
        public string AfterWork { get; set; }
        /// <summary>
	    /// 存在不足
	    /// </summary>
        public string Defects { get; set; }
        /// <summary>
	    /// 存在困难
	    /// </summary>
        public string Problems { get; set; }
        /// <summary>
	    /// 个人建议
	    /// </summary>
        public string Advices { get; set; }
        /// <summary>
	    /// 备注说明
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 鉴定状态（0草稿，1已确认）
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 创建人(对应员工表ID)
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 创建日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 确认人
	    /// </summary>
        public int? Checker { get; set; }
        /// <summary>
	    /// 确认日期
	    /// </summary>
        public System.DateTime? CheckDate { get; set; }
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