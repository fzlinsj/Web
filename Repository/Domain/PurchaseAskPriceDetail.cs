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
    public partial class PurchaseAskPriceDetail : Entity
    {
        public PurchaseAskPriceDetail()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.AskNo= string.Empty;
          this.FromType= string.Empty;
          this.ProductNo= string.Empty;
          this.ProductName= string.Empty;
          this.RequireDate= DateTime.Now;
          this.Remark= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AskNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SortNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FromType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FromBillID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FromLineNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProductNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProductName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ProductCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? UnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? RequireDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProviderID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ApplyReason { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TaxPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Discount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TaxRate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalFee { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalTax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? AskOrder { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? UsedUnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UsedUnitCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UsedPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ExRate { get; set; }

    }
}