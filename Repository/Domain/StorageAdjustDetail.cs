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
    public partial class StorageAdjustDetail : Entity
    {
        public StorageAdjustDetail()
        {
          this.CompanyCD= string.Empty;
          this.AdjustNo= string.Empty;
          this.AdjustType= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.BatchNo= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AdjustNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SortNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? UnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AdjustType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? AdjustCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? CostPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? CostPriceTotal { get; set; }
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
	    /// 批次
	    /// </summary>
        public string BatchNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? UsedUnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UsedUnitCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UsedPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ExRate { get; set; }

    }
}