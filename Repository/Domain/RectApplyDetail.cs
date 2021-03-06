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
    public partial class RectApplyDetail : Entity
    {
        public RectApplyDetail()
        {
          this.Id= 0;
          this.RectApplyNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.JobName= string.Empty;
          this.WorkPlace= string.Empty;
          this.WorkNature= string.Empty;
          this.UsedDate= DateTime.Now;
          this.Sex= string.Empty;
          this.WorkAge= string.Empty;
          this.WorkNeeds= string.Empty;
          this.OtherAbility= string.Empty;
          this.SalaryNote= string.Empty;
          this.JobDescripe= string.Empty;
          this.JobID= 0;
        }

        /// <summary>
	    /// 内部id，自动生成
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 申请编号
	    /// </summary>
        public string RectApplyNo { get; set; }
        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 招聘岗位
	    /// </summary>
        public string JobName { get; set; }
        /// <summary>
	    /// 需求人数
	    /// </summary>
        public int? RectCount { get; set; }
        /// <summary>
	    /// 工作地点
	    /// </summary>
        public string WorkPlace { get; set; }
        /// <summary>
	    /// 工作性质
	    /// </summary>
        public string WorkNature { get; set; }
        /// <summary>
	    /// 最迟上岗日期
	    /// </summary>
        public System.DateTime? UsedDate { get; set; }
        /// <summary>
	    /// 截止年龄（岁）
	    /// </summary>
        public int? MaxAge { get; set; }
        /// <summary>
	    /// 起始年龄（岁）
	    /// </summary>
        public int? MinAge { get; set; }
        /// <summary>
	    /// 性别(1 男，2 女)
	    /// </summary>
        public string Sex { get; set; }
        /// <summary>
	    /// 工作年限（1在读学生,2应届毕业生,3 一年以内,4一年以上,5三年以上,6五年以上,7十年以上,8二十年以上,9退休人员）
	    /// </summary>
        public string WorkAge { get; set; }
        /// <summary>
	    /// 学历ID(对应分类代码表ID)
	    /// </summary>
        public int? CultureLevel { get; set; }
        /// <summary>
	    /// 专业ID(对应分类代码表ID)
	    /// </summary>
        public int? Professional { get; set; }
        /// <summary>
	    /// 工作要求
	    /// </summary>
        public string WorkNeeds { get; set; }
        /// <summary>
	    /// 其他要求
	    /// </summary>
        public string OtherAbility { get; set; }
        /// <summary>
	    /// 可提供的待遇
	    /// </summary>
        public string SalaryNote { get; set; }
        /// <summary>
	    /// 职务说明
	    /// </summary>
        public string JobDescripe { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int JobID { get; set; }

    }
}