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
    public partial class PerformanceBetterDetail : Entity
    {
        public PerformanceBetterDetail()
        {
          this.CompanyCD= string.Empty;
          this.PlanNo= string.Empty;
          this.Content= string.Empty;
          this.CompleteAim= string.Empty;
          this.CompleteDate= DateTime.Now;
          this.CheckDate= DateTime.Now;
          this.CheckResult= string.Empty;
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
        public string PlanNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompleteAim { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CompleteDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Checker { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CheckDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CheckResult { get; set; }
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