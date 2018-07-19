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
    public partial class VoucherTemplate : Entity
    {
        public VoucherTemplate()
        {
          this.CompanyCD= string.Empty;
          this.TemNo= string.Empty;
          this.TemName= string.Empty;
          this.Abstract= string.Empty;
          this.Remark= string.Empty;
          this.UsedStatus= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        /// <summary>
	    /// 公司编号
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 模板编号
	    /// </summary>
        public string TemNo { get; set; }
        /// <summary>
	    /// 模板名称
	    /// </summary>
        public string TemName { get; set; }
        /// <summary>
	    /// 模板类型（1.采购订单，2. 销售订单，3. 委托代销单，4. 销售退货单，5. 采购入库，6. 其他出库单，7. 销售出库单，8. 其他入库单，9.收款单，10.付款单）
	    /// </summary>
        public int? TemType { get; set; }
        /// <summary>
	    /// 摘要
	    /// </summary>
        public string Abstract { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 启用状态(0 停用，1 启用)
	    /// </summary>
        public string UsedStatus { get; set; }
        /// <summary>
	    /// 制单人ID
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }

    }
}