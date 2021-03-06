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
    public partial class CarApply : Entity
    {
        public CarApply()
        {
          this.CompanyCD= string.Empty;
          this.RecordNo= string.Empty;
          this.Title= string.Empty;
          this.CarNo= string.Empty;
          this.ApplyDate= DateTime.Now;
          this.Reason= string.Empty;
          this.PlanDate= DateTime.Now;
          this.PlanTime= string.Empty;
          this.ReturnDate= DateTime.Now;
          this.ReturnTime= string.Empty;
          this.BillStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ConfirmDate= DateTime.Now;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 请车单编号
	    /// </summary>
        public string RecordNo { get; set; }
        /// <summary>
	    /// 请车单主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 车辆编号
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
	    /// 请车人部门
	    /// </summary>
        public int? ApplyDept { get; set; }
        /// <summary>
	    /// 申请事由
	    /// </summary>
        public string Reason { get; set; }
        /// <summary>
	    /// 人数
	    /// </summary>
        public int? LoadHumans { get; set; }
        /// <summary>
	    /// 载货重（吨）
	    /// </summary>
        public int? LoadGoods { get; set; }
        /// <summary>
	    /// 预定日期
	    /// </summary>
        public System.DateTime? PlanDate { get; set; }
        /// <summary>
	    /// 预定时间（精确到分）
	    /// </summary>
        public string PlanTime { get; set; }
        /// <summary>
	    /// 预计返回日期
	    /// </summary>
        public System.DateTime? ReturnDate { get; set; }
        /// <summary>
	    /// 预计返回时间（精确到分）
	    /// </summary>
        public string ReturnTime { get; set; }
        /// <summary>
	    /// 预计行驶公里数
	    /// </summary>
        public int? PlanMileage { get; set; }
        /// <summary>
	    /// 制单状态（1制单，2结单）
	    /// </summary>
        public string BillStatus { get; set; }
        /// <summary>
	    /// 制单人
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 制单日期
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 确认人
	    /// </summary>
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 确认日期
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }
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