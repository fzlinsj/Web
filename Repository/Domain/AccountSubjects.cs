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
using Repository.Core;

namespace Repository.Domain
{
    /// <summary>
	/// 
	/// </summary>
    public partial class AccountSubjects : Entity
    {
        public AccountSubjects()
        {
          this.CompanyCD= string.Empty;
          this.SubjectsCD= string.Empty;
          this.SubjectsName= string.Empty;
          this.ParentID= string.Empty;
          this.SubjectsType= string.Empty;
          this.BlanceDire= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UsedStatus= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SubjectsCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SubjectsName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ParentID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SubjectsType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Type { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BlanceDire { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? AuciliaryCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ForCurrencyAcc { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }

    }
}