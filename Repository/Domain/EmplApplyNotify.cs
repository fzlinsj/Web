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
    public partial class EmplApplyNotify : Entity
    {
        public EmplApplyNotify()
        {
          this.CompanyCD= string.Empty;
          this.NotifyNo= string.Empty;
          this.Title= string.Empty;
          this.EmplApplyNo= string.Empty;
          this.EmployeeID= 0;
          this.Reason= string.Empty;
          this.OutDate= DateTime.Now;
          this.IntDate= DateTime.Now;
          this.Remark= string.Empty;
          this.BillStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
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
        public string NotifyNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
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
        public int? NowDeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NowQuarterID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NowAdminLevel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NewDeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NewQuarterID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? NewAdminLevel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Reason { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? OutDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? IntDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BillStatus { get; set; }
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
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }
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