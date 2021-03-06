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
    public partial class CustComplain : Entity
    {
        public CustComplain()
        {
          this.CompanyCD= string.Empty;
          this.CustLinkTel= string.Empty;
          this.ComplainNo= string.Empty;
          this.Title= string.Empty;
          this.ComplainDate= DateTime.Now;
          this.Critical= string.Empty;
          this.State= string.Empty;
          this.DateUnit= string.Empty;
          this.Contents= string.Empty;
          this.DisposalProcess= string.Empty;
          this.Feedback= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.CanViewUser= string.Empty;
          this.CanViewUserName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 投诉客户
	    /// </summary>
        public int? CustID { get; set; }
        /// <summary>
	    /// 客户联系人
	    /// </summary>
        public int? CustLinkMan { get; set; }
        /// <summary>
	    /// 客户联系电话
	    /// </summary>
        public string CustLinkTel { get; set; }
        /// <summary>
	    /// 投诉单编号
	    /// </summary>
        public string ComplainNo { get; set; }
        /// <summary>
	    /// 投诉主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 投诉分类
	    /// </summary>
        public int? ComplainType { get; set; }
        /// <summary>
	    /// 接待人
	    /// </summary>
        public int? DestClerk { get; set; }
        /// <summary>
	    /// 投诉时间
	    /// </summary>
        public System.DateTime? ComplainDate { get; set; }
        /// <summary>
	    /// 紧急程度(1宽松,2一般,3较急,4紧急,5特急)
	    /// </summary>
        public string Critical { get; set; }
        /// <summary>
	    /// 状态（1处理中2未处理3已处理）
	    /// </summary>
        public string State { get; set; }
        /// <summary>
	    /// 花费时间单位（小时/天/月）
	    /// </summary>
        public string DateUnit { get; set; }
        /// <summary>
	    /// 花费时间
	    /// </summary>
        public decimal? SpendTime { get; set; }
        /// <summary>
	    /// 投诉内容
	    /// </summary>
        public string Contents { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ComplainedMan { get; set; }
        /// <summary>
	    /// 处理过程
	    /// </summary>
        public string DisposalProcess { get; set; }
        /// <summary>
	    /// 客户反馈
	    /// </summary>
        public string Feedback { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CanViewUser { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CanViewUserName { get; set; }

    }
}