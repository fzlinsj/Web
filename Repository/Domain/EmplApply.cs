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
    public partial class EmplApply : Entity
    {
        public EmplApply()
        {
          this.CompanyCD= string.Empty;
          this.EmplApplyNo= string.Empty;
          this.EmployeeID= 0;
          this.EnterDate= DateTime.Now;
          this.ApplyDate= DateTime.Now;
          this.HopeDate= DateTime.Now;
          this.NowDeptID= 0;
          this.NowQuarterID= 0;
          this.NewDeptID= 0;
          this.NewQuarterID= 0;
          this.ApplyType= string.Empty;
          this.Reason= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Title= string.Empty;
          this.Status= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string EmplApplyNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? EnterDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ApplyDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? HopeDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int NowDeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int NowQuarterID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? NowWage { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int NewDeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int NewQuarterID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? NewWage { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ApplyType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Reason { get; set; }
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
        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NowAdminLevelID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NewAdminLevelID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Status { get; set; }

    }
}