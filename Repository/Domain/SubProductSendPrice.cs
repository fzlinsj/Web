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
    public partial class SubProductSendPrice : Entity
    {
        public SubProductSendPrice()
        {
          this.CompanyCD= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SendPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SendPriceTax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SendTax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Discount { get; set; }
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
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}