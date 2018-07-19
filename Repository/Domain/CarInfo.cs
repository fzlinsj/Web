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
    public partial class CarInfo : Entity
    {
        public CarInfo()
        {
          this.CompanyCD= string.Empty;
          this.CarNo= string.Empty;
          this.CarName= string.Empty;
          this.CarMark= string.Empty;
          this.CarType= string.Empty;
          this.Factory= string.Empty;
          this.FuelType= string.Empty;
          this.EngineNo= string.Empty;
          this.BuyDate= DateTime.Now;
          this.VendorName= string.Empty;
          this.VendorAddress= string.Empty;
          this.Contact= string.Empty;
          this.ContactTel= string.Empty;
          this.Status= string.Empty;
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
	    /// 车辆编号
	    /// </summary>
        public string CarNo { get; set; }
        /// <summary>
	    /// 车辆名称
	    /// </summary>
        public string CarName { get; set; }
        /// <summary>
	    /// 车牌号
	    /// </summary>
        public string CarMark { get; set; }
        /// <summary>
	    /// 车辆类别（1小客，2大客，3小货，4大货，5其他）
	    /// </summary>
        public string CarType { get; set; }
        /// <summary>
	    /// 车辆型号
	    /// </summary>
        public string Factory { get; set; }
        /// <summary>
	    /// 排量（升）
	    /// </summary>
        public decimal? Displacement { get; set; }
        /// <summary>
	    /// 座位数
	    /// </summary>
        public int? SeatCount { get; set; }
        /// <summary>
	    /// 载重（吨）
	    /// </summary>
        public decimal? Carrying { get; set; }
        /// <summary>
	    /// 燃油类型（1汽油，2柴油，3天然气，4混合）
	    /// </summary>
        public string FuelType { get; set; }
        /// <summary>
	    /// 发动机号
	    /// </summary>
        public string EngineNo { get; set; }
        /// <summary>
	    /// 购买金额(元)
	    /// </summary>
        public decimal? BuyMoney { get; set; }
        /// <summary>
	    /// 购买日期
	    /// </summary>
        public System.DateTime? BuyDate { get; set; }
        /// <summary>
	    /// 驾驶员ID
	    /// </summary>
        public int? Motorman { get; set; }
        /// <summary>
	    /// 所属部门
	    /// </summary>
        public int? UsedDept { get; set; }
        /// <summary>
	    /// 供应商名称
	    /// </summary>
        public string VendorName { get; set; }
        /// <summary>
	    /// 供应商地址
	    /// </summary>
        public string VendorAddress { get; set; }
        /// <summary>
	    /// 联系人
	    /// </summary>
        public string Contact { get; set; }
        /// <summary>
	    /// 联系电话
	    /// </summary>
        public string ContactTel { get; set; }
        /// <summary>
	    /// 车辆状态（1正常，2停用）
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 登记人
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 登记日期
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