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
    public partial class StorageCost : Entity
    {
        public StorageCost()
        {
          this.CompanyCD= string.Empty;
          this.YearMonth= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.ActionDate= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string YearMonth { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PeriodBeginCost { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PeriodBeginCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PeriodEndCost { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PeriodEndCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ActionUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ActionDate { get; set; }

    }
}