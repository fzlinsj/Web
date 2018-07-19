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
    public partial class InfoWarehouse : Entity
    {
        public InfoWarehouse()
        {
          this.InfoNo= string.Empty;
          this.Flag= string.Empty;
          this.Title= string.Empty;
          this.Keyword= string.Empty;
          this.Content= string.Empty;
          this.IsShow= string.Empty;
          this.SourceFrom= string.Empty;
          this.SafeLevel= string.Empty;
          this.Author= string.Empty;
          this.Attachment= string.Empty;
          this.CreateUserID= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.ProfessionType= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string InfoNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Flag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TypeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Keyword { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsShow { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SourceFrom { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SafeLevel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Author { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Attachment { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CreateUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 查看次数
	    /// </summary>
        public int? ReadTimes { get; set; }
        /// <summary>
	    /// 文档下载次数
	    /// </summary>
        public int? DownloadTimes { get; set; }
        /// <summary>
	    /// 所属行业分类（对应行业分类）
	    /// </summary>
        public string ProfessionType { get; set; }
        /// <summary>
	    /// 信息有效期（天数）
	    /// </summary>
        public int? ExpireDays { get; set; }

    }
}