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
    public partial class CostDetails : Entity
    {
        public CostDetails()
        {
          this.Ctid= 0;
          this.ItemName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Ctid { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ItemName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Materials { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Wage { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? Overhead { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BurningPower { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalCost { get; set; }

    }
}