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
    public partial class PayBill : Entity
    {
        public PayBill()
        {
          this.CompanyCD= string.Empty;
          this.CreatDate= DateTime.Now;
          this.PayNo= string.Empty;
          this.CustName= string.Empty;
          this.PayDate= DateTime.Now;
          this.AcceWay= string.Empty;
          this.BankName= string.Empty;
          this.BankNo= string.Empty;
          this.ConfirmStatus= string.Empty;
          this.ConfirmDate= DateTime.Now;
          this.IsAccount= string.Empty;
          this.AccountDate= DateTime.Now;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.BlendingType= string.Empty;
          this.FromTBName= string.Empty;
          this.FileName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? BillingID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreatDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PayNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PayAmount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? PayDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AcceWay { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Executor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BankName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BankNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ConfirmStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsAccount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Accountor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? AccountDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ModifiedUserID { get; set; }
        /// <summary>
	    /// 生成凭证ID
	    /// </summary>
        public int? AttestBillID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BlendingType { get; set; }
        /// <summary>
	    /// 币种
	    /// </summary>
        public int? CurrencyType { get; set; }
        /// <summary>
	    /// 汇率
	    /// </summary>
        public decimal? CurrencyRate { get; set; }
        /// <summary>
	    /// 往来客户主键
	    /// </summary>
        public int? CustID { get; set; }
        /// <summary>
	    /// 往来客户来源表
	    /// </summary>
        public string FromTBName { get; set; }
        /// <summary>
	    /// 往来客户来源表名称字段
	    /// </summary>
        public string FileName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProjectID { get; set; }

    }
}