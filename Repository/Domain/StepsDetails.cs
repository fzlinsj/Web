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
    public partial class StepsDetails : Entity
    {
        public StepsDetails()
        {
          this.CompanyCD= string.Empty;
          this.PayOrInComeType= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PayOrInComeType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SourceID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? BlendingID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BlendingAmount { get; set; }

    }
}