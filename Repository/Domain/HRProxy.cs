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
    public partial class HRProxy : Entity
    {
        public HRProxy()
        {
          this.CompanyCD= string.Empty;
          this.ProxyCompanyCD= string.Empty;
          this.ProxyCompanyName= string.Empty;
          this.Nature= string.Empty;
          this.Address= string.Empty;
          this.Corporate= string.Empty;
          this.Telephone= string.Empty;
          this.Fax= string.Empty;
          this.Email= string.Empty;
          this.Website= string.Empty;
          this.Important= string.Empty;
          this.Cooperation= string.Empty;
          this.Standard= string.Empty;
          this.ContactName= string.Empty;
          this.ContactTel= string.Empty;
          this.ContactMobile= string.Empty;
          this.ContactWeb= string.Empty;
          this.ContactPosition= string.Empty;
          this.ContactCardNo= string.Empty;
          this.ContactRemark= string.Empty;
          this.Remark= string.Empty;
          this.UsedStatus= string.Empty;
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
        public string ProxyCompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProxyCompanyName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Nature { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Address { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Corporate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Telephone { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Fax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Email { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Website { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Important { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Cooperation { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Standard { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactTel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactMobile { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactWeb { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactPosition { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactCardNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactRemark { get; set; }
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
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}