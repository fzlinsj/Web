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
    public partial class Financialbudgetbill : Entity
    {
        public Financialbudgetbill()
        {
          this.CompanyCD= string.Empty;
          this.BudgetCD= string.Empty;
          this.Title= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.Billstatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.PayType= string.Empty;
          this.FinancialBudgetType= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedUserID= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
        }

        /// <summary>
	    /// 公司编码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 单据编号
	    /// </summary>
        public string BudgetCD { get; set; }
        /// <summary>
	    /// 主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 部门ID
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 开始时间
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 结束时间
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 制单状态
	    /// </summary>
        public string Billstatus { get; set; }
        /// <summary>
	    /// 创建人
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 支付方式（1现金，2银行存款）
	    /// </summary>
        public string PayType { get; set; }
        /// <summary>
	    /// 币种
	    /// </summary>
        public int? CurrencyType { get; set; }
        /// <summary>
	    /// 汇率
	    /// </summary>
        public decimal? CurrencyRate { get; set; }
        /// <summary>
	    /// 预算总费用
	    /// </summary>
        public decimal? Budgetcost { get; set; }
        /// <summary>
	    /// 预算类型（分类属性设置）
	    /// </summary>
        public string FinancialBudgetType { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 最后更新人
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 确认人
	    /// </summary>
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 确认日期
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }

    }
}