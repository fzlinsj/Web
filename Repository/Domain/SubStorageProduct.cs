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
    public partial class SubStorageProduct : Entity
    {
        public SubStorageProduct()
        {
          this.CompanyCD= string.Empty;
          this.BatchNo= string.Empty;
        }

        /// <summary>
	    /// 公司编码 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 产品ID（对应产品档案表ID）
	    /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
	    /// 分店ID（对应组织结构表ID）
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 现有存量
	    /// </summary>
        public decimal? ProductCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BatchNo { get; set; }

    }
}