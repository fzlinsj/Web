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
    public partial class CommissionSalary : Entity
    {
        public CommissionSalary()
        {
          this.CompanyCD= string.Empty;
          this.EmployeeID= 0;
          this.CommDate= DateTime.Now;
          this.ItemNo= string.Empty;
          this.Amount= 0;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Flag= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime CommDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ItemNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? SalaryMoney { get; set; }
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
        public string Flag { get; set; }

    }
}