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
    public partial class EquipmentUsed : Entity
    {
        public EquipmentUsed()
        {
          this.RecordNo= string.Empty;
          this.EquipmentNo= string.Empty;
          this.CompanyCD= string.Empty;
          this.Status= string.Empty;
          this.ProposerID= 0;
          this.ProposerDeptID= 0;
          this.Critical= string.Empty;
          this.UsedDate= DateTime.Now;
          this.UsedType= string.Empty;
          this.UsedDemand= string.Empty;
          this.ApplyReason= string.Empty;
          this.ApplyDate= DateTime.Now;
          this.UseStartDate= DateTime.Now;
          this.UseEndDate= DateTime.Now;
          this.ReturnReason= string.Empty;
          this.ReturnRemark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.ApplyFactDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
        }

        /// <summary>
	    /// 单据编号
	    /// </summary>
        public string RecordNo { get; set; }
        /// <summary>
	    /// 设备编号
	    /// </summary>
        public string EquipmentNo { get; set; }
        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 设备状态
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 申请人ID
	    /// </summary>
        public int ProposerID { get; set; }
        /// <summary>
	    /// 申请人所属部门ID
	    /// </summary>
        public int ProposerDeptID { get; set; }
        /// <summary>
	    /// 紧急程度
	    /// </summary>
        public string Critical { get; set; }
        /// <summary>
	    /// 使用日期
	    /// </summary>
        public System.DateTime? UsedDate { get; set; }
        /// <summary>
	    /// 使用时长
	    /// </summary>
        public decimal? UsedLong { get; set; }
        /// <summary>
	    /// 使用数量
	    /// </summary>
        public decimal? UsedCount { get; set; }
        /// <summary>
	    /// 使用类型
	    /// </summary>
        public string UsedType { get; set; }
        /// <summary>
	    /// 配置要求
	    /// </summary>
        public string UsedDemand { get; set; }
        /// <summary>
	    /// 申请原因
	    /// </summary>
        public string ApplyReason { get; set; }
        /// <summary>
	    /// 申请日期
	    /// </summary>
        public System.DateTime ApplyDate { get; set; }
        /// <summary>
	    /// 领用日期
	    /// </summary>
        public System.DateTime? UseStartDate { get; set; }
        /// <summary>
	    /// 归还日期
	    /// </summary>
        public System.DateTime? UseEndDate { get; set; }
        /// <summary>
	    /// 归还人ID
	    /// </summary>
        public int? ReturnUserID { get; set; }
        /// <summary>
	    /// 归还人所属部门
	    /// </summary>
        public int? ReturnDeptID { get; set; }
        /// <summary>
	    /// 归还原因
	    /// </summary>
        public string ReturnReason { get; set; }
        /// <summary>
	    /// 归还备注
	    /// </summary>
        public string ReturnRemark { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ApplyFactDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? CreateUser { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }

    }
}