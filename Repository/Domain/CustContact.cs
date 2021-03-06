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
    public partial class CustContact : Entity
    {
        public CustContact()
        {
          this.CompanyCD= string.Empty;
          this.ContactNo= string.Empty;
          this.Title= string.Empty;
          this.LinkDate= DateTime.Now;
          this.Contents= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.CanViewUser= string.Empty;
          this.CanViewUserName= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 客户ID（关联客户信息表）
	    /// </summary>
        public int? CustID { get; set; }
        /// <summary>
	    /// 客户被联络人
	    /// </summary>
        public int? CustLinkMan { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ContactNo { get; set; }
        /// <summary>
	    /// 主题
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 联络事由ID(系统设置)
	    /// </summary>
        public int? LinkReasonID { get; set; }
        /// <summary>
	    /// 联络方式ID(系统设置)
	    /// </summary>
        public int? LinkMode { get; set; }
        /// <summary>
	    /// 联络时间
	    /// </summary>
        public System.DateTime? LinkDate { get; set; }
        /// <summary>
	    /// 联络人
	    /// </summary>
        public int? Linker { get; set; }
        /// <summary>
	    /// 联络内容
	    /// </summary>
        public string Contents { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CanViewUser { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CanViewUserName { get; set; }

    }
}