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
    public partial class DataMyCollector : Entity
    {
        public DataMyCollector()
        {
          this.CompanyCD= string.Empty;
          this.Flag= string.Empty;
          this.ReportDate= DateTime.Now;
          this.Owner= string.Empty;
          this.ReportTxt= string.Empty;
          this.ReadStatus= string.Empty;
          this.ReadDate= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? KeyWordID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ActionID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ActionDetailID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Frequency { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Flag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ReportDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Owner { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ReportTxt { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ReadStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ReadDate { get; set; }

    }
}