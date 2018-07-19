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
    public partial class SellOffer : Entity
    {
        public SellOffer()
        {
          this.CompanyCD= string.Empty;
          this.OfferNo= string.Empty;
          this.CustTel= string.Empty;
          this.FromType= string.Empty;
          this.Title= string.Empty;
          this.BusiType= string.Empty;
          this.ExpireDate= DateTime.Now;
          this.IsAddTax= string.Empty;
          this.OfferDate= DateTime.Now;
          this.PayRemark= string.Empty;
          this.DeliverRemark= string.Empty;
          this.PackTransit= string.Empty;
          this.Remark= string.Empty;
          this.BillStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.ExtField1= string.Empty;
          this.ExtField2= string.Empty;
          this.ExtField3= string.Empty;
          this.ExtField4= string.Empty;
          this.ExtField5= string.Empty;
          this.ExtField6= string.Empty;
          this.ExtField7= string.Empty;
          this.ExtField8= string.Empty;
          this.ExtField9= string.Empty;
          this.ExtField10= string.Empty;
          this.CanViewUser= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string OfferNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? CustID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustTel { get; set; }
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
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Seller { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SellDeptId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SellType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BusiType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? PayType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? MoneyType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? CarryType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TakeType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ExpireDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalTax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalFee { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Discount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? DiscountTotal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? RealTotal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsAddTax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? CountTotal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? CurrencyType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Rate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? QuoteTime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? OfferDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PayRemark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string DeliverRemark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PackTransit { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BillStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
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
        public int? Closer { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CloseDate { get; set; }
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
        public string ExtField1 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField2 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField3 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField4 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField5 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField6 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField7 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField8 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField9 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField10 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CanViewUser { get; set; }

    }
}