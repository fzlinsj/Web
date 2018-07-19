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
    public partial class PersonalMemo : Entity
    {
        public PersonalMemo()
        {
          this.CompanyCD= string.Empty;
          this.MemoNo= string.Empty;
          this.TItle= string.Empty;
          this.Content= string.Empty;
          this.CanViewUser= string.Empty;
          this.CanViewUserName= string.Empty;
          this.Attachment= string.Empty;
          this.MemoDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Status= string.Empty;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 备忘录编号(年月日时分秒+用户id)
	    /// </summary>
        public string MemoNo { get; set; }
        /// <summary>
	    /// 标题
	    /// </summary>
        public string TItle { get; set; }
        /// <summary>
	    /// 日记内容
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 可以查看备忘录的人员（ID，多个）
	    /// </summary>
        public string CanViewUser { get; set; }
        /// <summary>
	    /// 可以查看备忘录的人员姓名
	    /// </summary>
        public string CanViewUserName { get; set; }
        /// <summary>
	    /// 附件
	    /// </summary>
        public string Attachment { get; set; }
        /// <summary>
	    /// 备忘人
	    /// </summary>
        public int? Memoer { get; set; }
        /// <summary>
	    /// 备忘时间
	    /// </summary>
        public System.DateTime? MemoDate { get; set; }
        /// <summary>
	    /// 创建人ID(对应员工表ID)
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID（对应操作用户表中的UserID）
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 处理状态(0:未处理,1:已处理)
	    /// </summary>
        public string Status { get; set; }

    }
}