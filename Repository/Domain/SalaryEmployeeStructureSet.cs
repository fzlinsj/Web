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
    public partial class SalaryEmployeeStructureSet : Entity
    {
        public SalaryEmployeeStructureSet()
        {
          this.EmployeeID= 0;
          this.CompanyCD= string.Empty;
          this.IsCompanyRoyaltySet= string.Empty;
          this.IsDeptRoyaltySet= string.Empty;
          this.IsProductRoyaltySet= string.Empty;
          this.IsFixSalarySet= string.Empty;
          this.IsPieceWorkSet= string.Empty;
          this.IsInsurenceSet= string.Empty;
          this.IsPerIncomeTaxSet= string.Empty;
          this.IsQuteerSet= string.Empty;
          this.IsTimeWorkSet= string.Empty;
          this.IsPersonalRoyaltySet= string.Empty;
          this.ModifiedUserID= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.IsPerformanceSet= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsCompanyRoyaltySet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsDeptRoyaltySet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsProductRoyaltySet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsFixSalarySet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsPieceWorkSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsInsurenceSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsPerIncomeTaxSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsQuteerSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsTimeWorkSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsPersonalRoyaltySet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsPerformanceSet { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? CompanyRatePercent { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? DeptRatePercent { get; set; }

    }
}