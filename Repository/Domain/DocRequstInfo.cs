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
    public partial class DocRequstInfo : Entity
    {
        public DocRequstInfo()
        {
          this.CompanyCD= string.Empty;
          this.DocumentNo= string.Empty;
          this.SecretLevel= string.Empty;
          this.EmerLevel= string.Empty;
          this.Main= string.Empty;
          this.RequestTitle= string.Empty;
          this.Description= string.Empty;
          this.RequstNo= string.Empty;
          this.RequestDate= DateTime.Now;
          this.UploadDate= DateTime.Now;
          this.DocumentName= string.Empty;
          this.DocumentURL= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 请示编号
	    /// </summary>
        public string DocumentNo { get; set; }
        /// <summary>
	    /// 请示类型
	    /// </summary>
        public int? RequstDocType { get; set; }
        /// <summary>
	    /// 秘密等级(1秘密，2机密，3绝密，4不公开，5一般)
	    /// </summary>
        public string SecretLevel { get; set; }
        /// <summary>
	    /// 紧急程度(1特提、2特急、3加急、4平急)
	    /// </summary>
        public string EmerLevel { get; set; }
        /// <summary>
	    /// 主送领导
	    /// </summary>
        public string Main { get; set; }
        /// <summary>
	    /// 请示金额
	    /// </summary>
        public decimal? RequestMoney { get; set; }
        /// <summary>
	    /// 请示标题
	    /// </summary>
        public string RequestTitle { get; set; }
        /// <summary>
	    /// 内容摘要
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 请示文号
	    /// </summary>
        public string RequstNo { get; set; }
        /// <summary>
	    /// 请示日期
	    /// </summary>
        public System.DateTime? RequestDate { get; set; }
        /// <summary>
	    /// 请示部门
	    /// </summary>
        public int? RequestDept { get; set; }
        /// <summary>
	    /// 拟稿人
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 上传人ID
	    /// </summary>
        public int? UploadUserID { get; set; }
        /// <summary>
	    /// 上传时间
	    /// </summary>
        public System.DateTime? UploadDate { get; set; }
        /// <summary>
	    /// 文档名称
	    /// </summary>
        public string DocumentName { get; set; }
        /// <summary>
	    /// 文档URL
	    /// </summary>
        public string DocumentURL { get; set; }
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