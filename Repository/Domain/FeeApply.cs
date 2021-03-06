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
    public partial class FeeApply : Entity
    {
        public FeeApply()
        {
          this.CompanyCD= string.Empty;
          this.ExpCode= string.Empty;
          this.Title= string.Empty;
          this.AriseDate= DateTime.Now;
          this.NeedDate= DateTime.Now;
          this.PayType= string.Empty;
          this.Reason= string.Empty;
          this.Status= string.Empty;
          this.CreateDate= DateTime.Now;
          this.SellChanceNo= string.Empty;
          this.IsReimburse= string.Empty;
          this.ModifiedUserID= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
          this.CanViewUser= string.Empty;
          this.Attachment= string.Empty;
          this.EndReimbTime= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExpCode { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Applyor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? AriseDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? NeedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalAmount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PayType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Reason { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TransactorID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Status { get; set; }
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
        public int? ExpType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? CustID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SellChanceNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsReimburse { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
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
        public string CanViewUser { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProjectID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Attachment { get; set; }
        /// <summary>
	    /// 报销截止日期
	    /// </summary>
        public System.DateTime? EndReimbTime { get; set; }

    }
}