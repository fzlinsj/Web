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
    public partial class CodeFeeType : Entity
    {
        public CodeFeeType()
        {
          this.CompanyCD= string.Empty;
          this.CodeName= string.Empty;
          this.Flag= 0;
          this.Description= string.Empty;
          this.UsedStatus= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.FeeSubjectsNo= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CodeName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int Flag { get; set; }
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
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FeeSubjectsNo { get; set; }

    }
}