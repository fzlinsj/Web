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
    public partial class T0004CompanyInfo : Entity
    {
        public T0004CompanyInfo()
        {
          this.Id= 0;
          this.EmpNo= string.Empty;
          this.EmpName= string.Empty;
          this.Intime= DateTime.Now;
          this.EmpWorkYear= 0;
          this.DeductionMoney= 0;
          this.TrueSalary= 0;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Pid { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string EmpNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string EmpName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime Intime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Salary { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int EmpWorkYear { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal DeductionMoney { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal TrueSalary { get; set; }

    }
}