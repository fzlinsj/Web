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
    public partial class SalaryReport : Entity
    {
        public SalaryReport()
        {
          this.CompanyCD= string.Empty;
          this.ReprotNo= string.Empty;
          this.ReportName= string.Empty;
          this.ReportMonth= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.Creator= 0;
          this.CreateDate= DateTime.Now;
          this.Status= string.Empty;
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
        public string ReprotNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ReportName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ReportMonth { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime StartDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime EndDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int Creator { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Status { get; set; }
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