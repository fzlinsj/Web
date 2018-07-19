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
    public partial class StoreFetchBill : Entity
    {
        public StoreFetchBill()
        {
          this.CompanyCD= string.Empty;
          this.SFNo= string.Empty;
          this.SFBillNum= string.Empty;
          this.SFDate= DateTime.Now;
          this.BankName= string.Empty;
          this.AccountNo= string.Empty;
          this.Type= string.Empty;
          this.ConfirmStatus= string.Empty;
          this.ConfirmDate= DateTime.Now;
          this.IsAccount= string.Empty;
          this.AccountDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Summary= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SFNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SFBillNum { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? SFDate { get; set; }
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
        public string AccountNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Type { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
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
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Summary { get; set; }
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