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
    public partial class QualityCheckApplyDetail : Entity
    {
        public QualityCheckApplyDetail()
        {
          this.ApplyNo= string.Empty;
          this.Remark= string.Empty;
          this.FromType= string.Empty;
          this.CompanyCD= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string ApplyNo { get; set; }
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
        public decimal? ProductCount { get; set; }
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
        public int? FromLineNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 已报检数量
	    /// </summary>
        public decimal? CheckedCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? RealCheckedCount { get; set; }
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
        public decimal? ExRate { get; set; }

    }
}