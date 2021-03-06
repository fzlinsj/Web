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
    public partial class CarDispatch : Entity
    {
        public CarDispatch()
        {
          this.CompanyCD= string.Empty;
          this.RecordNo= string.Empty;
          this.Title= string.Empty;
          this.CarNo= string.Empty;
          this.ApplyDate= DateTime.Now;
          this.Reason= string.Empty;
          this.RequireDate= DateTime.Now;
          this.RequireTime= string.Empty;
          this.PlanReturnDate= DateTime.Now;
          this.PlanReturnTime= string.Empty;
          this.OutDate= DateTime.Now;
          this.OutTime= string.Empty;
          this.BackDate= DateTime.Now;
          this.BackTime= string.Empty;
          this.IsReturn= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 派车单据号
	    /// </summary>
        public string RecordNo { get; set; }
        /// <summary>
	    /// 派车单主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 对应请车单（对应请车单表中的ID）
	    /// </summary>
        public int? ApplyID { get; set; }
        /// <summary>
	    /// 车辆编号（对应车辆信息表编号）
	    /// </summary>
        public string CarNo { get; set; }
        /// <summary>
	    /// 申请日期
	    /// </summary>
        public System.DateTime? ApplyDate { get; set; }
        /// <summary>
	    /// 请车人
	    /// </summary>
        public int? Appler { get; set; }
        /// <summary>
	    /// 请车部门
	    /// </summary>
        public int? ApplyDept { get; set; }
        /// <summary>
	    /// 请车事由
	    /// </summary>
        public string Reason { get; set; }
        /// <summary>
	    /// 人数（人）
	    /// </summary>
        public int? LoadHumans { get; set; }
        /// <summary>
	    /// 载货重（吨）
	    /// </summary>
        public int? LoadGoods { get; set; }
        /// <summary>
	    /// 需车日期
	    /// </summary>
        public System.DateTime? RequireDate { get; set; }
        /// <summary>
	    /// 需车时间（精确到分）
	    /// </summary>
        public string RequireTime { get; set; }
        /// <summary>
	    /// 预计返回日期
	    /// </summary>
        public System.DateTime? PlanReturnDate { get; set; }
        /// <summary>
	    /// 预计返回时间（精确到分）
	    /// </summary>
        public string PlanReturnTime { get; set; }
        /// <summary>
	    /// 预计行驶公里数
	    /// </summary>
        public int? PlanMileage { get; set; }
        /// <summary>
	    /// 出车日期
	    /// </summary>
        public System.DateTime? OutDate { get; set; }
        /// <summary>
	    /// 出车时间
	    /// </summary>
        public string OutTime { get; set; }
        /// <summary>
	    /// 回车日期
	    /// </summary>
        public System.DateTime? BackDate { get; set; }
        /// <summary>
	    /// 回车时间
	    /// </summary>
        public string BackTime { get; set; }
        /// <summary>
	    /// 是否已还车（0否，1是）
	    /// </summary>
        public string IsReturn { get; set; }
        /// <summary>
	    /// 实际行驶公里数
	    /// </summary>
        public int? RealMileage { get; set; }
        /// <summary>
	    /// 制单人
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
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

    }
}