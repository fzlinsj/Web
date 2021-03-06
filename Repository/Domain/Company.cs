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
using System.ComponentModel.DataAnnotations.Schema;
using Repository.Core;

namespace Repository.Domain
{
    /// <summary>
    /// 企业基本信息表
    /// </summary>
    [Table("Company")]
    public partial class Company : Entity
    {
        public Company()
        {
          this.NameCn= string.Empty;
          this.NameEn= string.Empty;
          this.NameShort= string.Empty;
          this.PYShort= string.Empty;
          this.ArtiPerson= string.Empty;
          this.SetupAddr= string.Empty;
          this.SetupDate= DateTime.Now;
          this.TaxCD= string.Empty;
          this.BusiNumber= string.Empty;
          this.IsTax= string.Empty;
          this.Country= string.Empty;
          this.ProfessionType= string.Empty;
          this.Province= string.Empty;
          this.City= string.Empty;
          this.ContactName= string.Empty;
          this.Tel= string.Empty;
          this.Mobile= string.Empty;
          this.Email= string.Empty;
          this.Fax= string.Empty;
          this.Qq= string.Empty;
          this.Msn= string.Empty;
          this.Im= string.Empty;
          this.Addr= string.Empty;
          this.Post= string.Empty;
          this.WebSite= string.Empty;
          this.SalesMan= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 企业中文名称
	    /// </summary>
        public string NameCn { get; set; }
        /// <summary>
	    /// 企业英文名称
	    /// </summary>
        public string NameEn { get; set; }
        /// <summary>
	    /// 企业简称
	    /// </summary>
        public string NameShort { get; set; }
        /// <summary>
	    /// 企业拼应代码
	    /// </summary>
        public string PYShort { get; set; }
        /// <summary>
	    /// 法人代表
	    /// </summary>
        public string ArtiPerson { get; set; }
        /// <summary>
	    /// 注册地址
	    /// </summary>
        public string SetupAddr { get; set; }
        /// <summary>
	    /// 成立时间
	    /// </summary>
        public System.DateTime? SetupDate { get; set; }
        /// <summary>
	    /// 注册资本(万元)
	    /// </summary>
        public decimal? SetupMoney { get; set; }
        /// <summary>
	    /// 资产规模(万元)
	    /// </summary>
        public decimal? CapitalScale { get; set; }
        /// <summary>
	    /// 年销售额(万元)
	    /// </summary>
        public decimal? SaleroomY { get; set; }
        /// <summary>
	    /// 年利润额(万元)
	    /// </summary>
        public decimal? ProfitY { get; set; }
        /// <summary>
	    /// 税务登记号
	    /// </summary>
        public string TaxCD { get; set; }
        /// <summary>
	    /// 营业执照号
	    /// </summary>
        public string BusiNumber { get; set; }
        /// <summary>
	    /// 是否为一般纳税人（0否，1是）
	    /// </summary>
        public string IsTax { get; set; }
        /// <summary>
	    /// 国家地区
	    /// </summary>
        public string Country { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProfessionType { get; set; }
        /// <summary>
	    /// 省
	    /// </summary>
        public string Province { get; set; }
        /// <summary>
	    /// 市（县
	    /// </summary>
        public string City { get; set; }
        /// <summary>
	    /// 联系人
	    /// </summary>
        public string ContactName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Tel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Mobile { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Email { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Fax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Qq { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Msn { get; set; }
        /// <summary>
	    /// 其他即时联系方式
	    /// </summary>
        public string Im { get; set; }
        /// <summary>
	    /// 联系地址
	    /// </summary>
        public string Addr { get; set; }
        /// <summary>
	    /// 邮编
	    /// </summary>
        public string Post { get; set; }
        /// <summary>
	    /// 公司网址
	    /// </summary>
        public string WebSite { get; set; }
        /// <summary>
	    /// 分管人员
	    /// </summary>
        public string SalesMan { get; set; }
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