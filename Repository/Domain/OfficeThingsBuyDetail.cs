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
    public partial class OfficeThingsBuyDetail : Entity
    {
        public OfficeThingsBuyDetail()
        {
          this.CompanyCD= string.Empty;
          this.BuyRecordNo= string.Empty;
          this.ThingNo= string.Empty;
          this.Provider= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 采购单编号
	    /// </summary>
        public string BuyRecordNo { get; set; }
        /// <summary>
	    /// 用品编号（对应用品表中的用品编号）
	    /// </summary>
        public string ThingNo { get; set; }
        /// <summary>
	    /// 供应商
	    /// </summary>
        public string Provider { get; set; }
        /// <summary>
	    /// 采购单价
	    /// </summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
	    /// 采购数量
	    /// </summary>
        public decimal? BuyCount { get; set; }
        /// <summary>
	    /// 采购金额
	    /// </summary>
        public decimal? BuyMoney { get; set; }
        /// <summary>
	    /// 最后更新时间
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}