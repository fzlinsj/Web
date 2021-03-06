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
    public partial class RectApply : Entity
    {
        public RectApply()
        {
          this.RectApplyNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.RequstReason= string.Empty;
          this.Remark= string.Empty;
          this.BillStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 申请编号
	    /// </summary>
        public string RectApplyNo { get; set; }
        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 申请部门
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 部门编制（人）
	    /// </summary>
        public int? MaxNum { get; set; }
        /// <summary>
	    /// 现有人数（人）
	    /// </summary>
        public int? NowNum { get; set; }
        /// <summary>
	    /// 经办人(对应员工表ID)
	    /// </summary>
        public int? Principal { get; set; }
        /// <summary>
	    /// 经办人(对应员工表ID)
	    /// </summary>
        public string RequstReason { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 单据状态（1制单，2执行，4手工结单）
	    /// </summary>
        public string BillStatus { get; set; }
        /// <summary>
	    /// 制单人
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 确认人
	    /// </summary>
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 确认日期
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }
        /// <summary>
	    /// 结单人ID
	    /// </summary>
        public int? Closer { get; set; }
        /// <summary>
	    /// 结单日期
	    /// </summary>
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
	    /// 更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? RequireNum { get; set; }

    }
}