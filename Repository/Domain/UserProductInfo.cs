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
    public partial class UserProductInfo : Entity
    {
        public UserProductInfo()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.ProductNum= string.Empty;
          this.ProductName= string.Empty;
          this.Bref= string.Empty;
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
        public string ProductNum { get; set; }
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
        public string Bref { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Memo { get; set; }

    }
}