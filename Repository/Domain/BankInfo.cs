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
    public partial class BankInfo : Entity
    {
        public BankInfo()
        {
          this.CompanyCD= string.Empty;
          this.BigType= string.Empty;
          this.CustNo= string.Empty;
          this.CustName= string.Empty;
          this.CustNam= string.Empty;
          this.PYShort= string.Empty;
          this.ContactName= string.Empty;
          this.Tel= string.Empty;
          this.Fax= string.Empty;
          this.Mobile= string.Empty;
          this.Addr= string.Empty;
          this.Remark= string.Empty;
          this.UsedStatus= string.Empty;
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
        public string BigType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustNam { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PYShort { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Tel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Fax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Mobile { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Addr { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }
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