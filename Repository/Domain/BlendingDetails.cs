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
    public partial class BlendingDetails : Entity
    {
        public BlendingDetails()
        {
          this.CompanyCD= string.Empty;
          this.PayOrInComeType= string.Empty;
          this.SourceDt= string.Empty;
          this.BillCD= string.Empty;
          this.BillingType= string.Empty;
          this.InvoiceType= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ContactUnits= string.Empty;
          this.ExecutDate= DateTime.Now;
          this.Status= string.Empty;
        }

        /// <summary>
	    /// 公司编码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 来源表类型 1.付款单 2.收款单
	    /// </summary>
        public string PayOrInComeType { get; set; }
        /// <summary>
	    /// 业务单表ID
	    /// </summary>
        public int? BillingID { get; set; }
        /// <summary>
	    /// 源单表
	    /// </summary>
        public string SourceDt { get; set; }
        /// <summary>
	    /// 源单表ID
	    /// </summary>
        public int? SourceID { get; set; }
        /// <summary>
	    /// 源单编码
	    /// </summary>
        public string BillCD { get; set; }
        /// <summary>
	    /// 2采购订单 1销售订单 3销售退货单 4代销结算单 5采购退货单
	    /// </summary>
        public string BillingType { get; set; }
        /// <summary>
	    /// 发票类型  1增值税发票，2普通地税，3普通国税，4收据
	    /// </summary>
        public string InvoiceType { get; set; }
        /// <summary>
	    /// 源单总金额
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 已勾兑金额
	    /// </summary>
        public decimal? YAccounts { get; set; }
        /// <summary>
	    /// 未勾兑金额
	    /// </summary>
        public decimal? NAccounts { get; set; }
        /// <summary>
	    /// 勾兑日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 往来客户
	    /// </summary>
        public string ContactUnits { get; set; }
        /// <summary>
	    /// 操作日期
	    /// </summary>
        public System.DateTime? ExecutDate { get; set; }
        /// <summary>
	    /// 操作人
	    /// </summary>
        public int? Executor { get; set; }
        /// <summary>
	    /// 状态  0：未勾兑完成 1：勾兑完成
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 币种
	    /// </summary>
        public int? CurrencyType { get; set; }
        /// <summary>
	    /// 汇率
	    /// </summary>
        public decimal? CurrencyRate { get; set; }

    }
}