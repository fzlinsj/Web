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
    public partial class SellReport : Entity
    {
        public SellReport()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.ProductName= string.Empty;
          this.Createdate= DateTime.Now;
          this.Memo= string.Empty;
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
        public int? SellDept { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProductName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SellNum { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SellPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? Createdate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Memo { get; set; }

    }
}