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
    public partial class ProjectBudget : Entity
    {
        public ProjectBudget()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.BudgetTime= DateTime.Now;
          this.Userlist= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProjectID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? BudgetPerson { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? BudgetTime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Status { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Userlist { get; set; }

    }
}