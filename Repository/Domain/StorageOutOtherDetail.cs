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
    public partial class StorageOutOtherDetail : Entity
    {
        public StorageOutOtherDetail()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.OutNo= string.Empty;
          this.Remark= string.Empty;
          this.FromType= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.BatchNo= string.Empty;
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
        public string OutNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SortNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? StorageID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 基本单位
	    /// </summary>
        public int? UnitID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ProductCount { get; set; }
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
	    /// 批次
	    /// </summary>
        public string BatchNo { get; set; }
        /// <summary>
	    /// 单位
	    /// </summary>
        public int? UsedUnitID { get; set; }
        /// <summary>
	    /// 数量
	    /// </summary>
        public decimal? UsedUnitCount { get; set; }
        /// <summary>
	    /// 单价（对应于单位的单价，也就是明细中显示的实际单价）
	    /// </summary>
        public decimal? UsedPrice { get; set; }
        /// <summary>
	    /// 单位换算率（单位与基本计量单位之间的换算比例，取自计量单位组表）
	    /// </summary>
        public decimal? ExRate { get; set; }

    }
}