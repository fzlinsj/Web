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
    public partial class PersonalLinkman : Entity
    {
        public PersonalLinkman()
        {
          this.CompanyCD= string.Empty;
          this.LinkmanName= string.Empty;
          this.Sex= string.Empty;
          this.CompanyName= string.Empty;
          this.Birthday= DateTime.Now;
          this.MobilePhone= string.Empty;
          this.CompanyPhone= string.Empty;
          this.Email= string.Empty;
          this.Fax= string.Empty;
          this.Qq= string.Empty;
          this.Icq= string.Empty;
          this.Msn= string.Empty;
          this.CompanyWebsite= string.Empty;
          this.CompanyAddress= string.Empty;
          this.Principalship= string.Empty;
          this.Remark= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? LinkmanGroupID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string LinkmanName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Sex { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? Birthday { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyPhone { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Email { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Fax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Qq { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Icq { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Msn { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyWebsite { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Principalship { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }

    }
}