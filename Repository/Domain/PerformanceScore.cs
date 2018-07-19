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
    public partial class PerformanceScore : Entity
    {
        public PerformanceScore()
        {
          this.CompanyCD= string.Empty;
          this.TaskNo= string.Empty;
          this.TemplateNo= string.Empty;
          this.ElemName= string.Empty;
          this.StepName= string.Empty;
          this.ScoreDate= DateTime.Now;
          this.AdviceNote= string.Empty;
          this.FeeBack= string.Empty;
          this.Note= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Status= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 考核任务编号（对应考核任务表中的编号）
	    /// </summary>
        public string TaskNo { get; set; }
        /// <summary>
	    /// 模板编号
	    /// </summary>
        public string TemplateNo { get; set; }
        /// <summary>
	    /// 被考核人（对应员工表ID）
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 指标ID
	    /// </summary>
        public int? ElemID { get; set; }
        /// <summary>
	    /// 指标名称
	    /// </summary>
        public string ElemName { get; set; }
        /// <summary>
	    /// 步骤顺序
	    /// </summary>
        public int? StepNo { get; set; }
        /// <summary>
	    /// 步骤名称（如：初评，复评）
	    /// </summary>
        public string StepName { get; set; }
        /// <summary>
	    /// 评分人员(对应员工表ID)
	    /// </summary>
        public int? ScoreEmployee { get; set; }
        /// <summary>
	    /// 打分
	    /// </summary>
        public int? Score { get; set; }
        /// <summary>
	    /// 评分日期
	    /// </summary>
        public System.DateTime? ScoreDate { get; set; }
        /// <summary>
	    /// 评语
	    /// </summary>
        public string AdviceNote { get; set; }
        /// <summary>
	    /// 被考核人反馈
	    /// </summary>
        public string FeeBack { get; set; }
        /// <summary>
	    /// 说明事项
	    /// </summary>
        public string Note { get; set; }
        /// <summary>
	    /// 更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 考核得分权重
	    /// </summary>
        public decimal? Rate { get; set; }
        /// <summary>
	    /// 0表示草稿状态,1代表已确认状态
	    /// </summary>
        public string Status { get; set; }

    }
}