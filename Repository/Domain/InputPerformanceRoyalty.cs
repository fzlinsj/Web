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
    public partial class InputPerformanceRoyalty : Entity
    {
        public InputPerformanceRoyalty()
        {
          this.EmployeeID= 0;
          this.TaskNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.TaskFlag= string.Empty;
          this.ModifiedUserID= string.Empty;
          this.CreateTime= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TaskNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TaskNum { get; set; }
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
        public string TaskFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BaseMoney { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PerformanceMoney { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Confficent { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateTime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }

    }
}