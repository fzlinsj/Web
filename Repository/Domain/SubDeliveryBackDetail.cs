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
    public partial class SubDeliveryBackDetail : Entity
    {
        public SubDeliveryBackDetail()
        {
          this.CompanyCD= string.Empty;
          this.BackNo= string.Empty;
          this.BackBatchNo= string.Empty;
          this.SendBatchNo= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BackNo { get; set; }
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
        public int? StorageID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BackCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BackPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BackPriceTotal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UsedUnitCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? UnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ExRate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BackBatchNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SendBatchNo { get; set; }

    }
}