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
    public partial class BillType : Entity
    {
        public BillType()
        {
          this.TypeName= string.Empty;
          this.ModuleName= string.Empty;
          this.AuditFlag= string.Empty;
          this.Description= string.Empty;
          this.PageURL= string.Empty;
          this.UsedStatus= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.TypeLabel= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? TypeFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TypeCode { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TypeName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AuditFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PageURL { get; set; }
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
        /// <summary>
	    /// 
	    /// </summary>
        public string TypeLabel { get; set; }

    }
}