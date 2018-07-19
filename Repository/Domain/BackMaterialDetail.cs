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
    public partial class BackMaterialDetail : Entity
    {
        public BackMaterialDetail()
        {
          this.CompanyCD= string.Empty;
          this.BackNo= string.Empty;
          this.Remark= string.Empty;
          this.FromType= string.Empty;
          this.FromBillNo= string.Empty;
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
        public decimal? Price { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FromType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FromBillID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FromBillNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FromLineNo { get; set; }
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
        public int? UnitID { get; set; }
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
        /// <summary>
	    /// 
	    /// </summary>
        public string BatchNo { get; set; }

    }
}