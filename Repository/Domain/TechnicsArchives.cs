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
    public partial class TechnicsArchives : Entity
    {
        public TechnicsArchives()
        {
          this.CompanyCD= string.Empty;
          this.TechNo= string.Empty;
          this.PYShort= string.Empty;
          this.TechName= string.Empty;
          this.Description= string.Empty;
          this.UsedStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Remark= string.Empty;
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
        public string TechNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PYShort { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TechName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Description { get; set; }
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
        public string Remark { get; set; }
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