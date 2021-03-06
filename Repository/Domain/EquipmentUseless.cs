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
    public partial class EquipmentUseless : Entity
    {
        public EquipmentUseless()
        {
          this.RecordNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.EquipmentNo= string.Empty;
          this.ApplyUserID= 0;
          this.DeptID= 0;
          this.ApplyDate= DateTime.Now;
          this.UselessDate= DateTime.Now;
          this.UsedDescription= string.Empty;
          this.UselessReason= string.Empty;
          this.UselessStatus= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        /// <summary>
	    /// 报废单据编号
	    /// </summary>
        public string RecordNo { get; set; }
        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 设备编号
	    /// </summary>
        public string EquipmentNo { get; set; }
        /// <summary>
	    /// 申请人ID
	    /// </summary>
        public int ApplyUserID { get; set; }
        /// <summary>
	    /// 申请人部门ID
	    /// </summary>
        public int DeptID { get; set; }
        /// <summary>
	    /// 申请时间
	    /// </summary>
        public System.DateTime ApplyDate { get; set; }
        /// <summary>
	    /// 报废时间
	    /// </summary>
        public System.DateTime? UselessDate { get; set; }
        /// <summary>
	    /// 设备使用情况说明
	    /// </summary>
        public string UsedDescription { get; set; }
        /// <summary>
	    /// 报废原因
	    /// </summary>
        public string UselessReason { get; set; }
        /// <summary>
	    /// 报废费用
	    /// </summary>
        public decimal? Cost { get; set; }
        /// <summary>
	    /// 报废状态
	    /// </summary>
        public string UselessStatus { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 制单人
	    /// </summary>
        public int? CreateUser { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }

    }
}