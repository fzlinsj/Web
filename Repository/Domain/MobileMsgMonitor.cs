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
    public partial class MobileMsgMonitor : Entity
    {
        public MobileMsgMonitor()
        {
          this.CompanyCD= string.Empty;
          this.MsgType= string.Empty;
          this.SendUserName= string.Empty;
          this.ReceiveUserName= string.Empty;
          this.ReceiveMobile= string.Empty;
          this.Content= string.Empty;
          this.Status= string.Empty;
          this.CreateDate= DateTime.Now;
          this.SendDate= DateTime.Now;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 短信区分标识（0：内部员工，1：领导汇报，2：客户联系人）
	    /// </summary>
        public string MsgType { get; set; }
        /// <summary>
	    /// 信息发送人ID
	    /// </summary>
        public int? SendUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SendUserName { get; set; }
        /// <summary>
	    /// 信息接收人ID（多个，用逗号分隔）
	    /// </summary>
        public int? ReceiveUserID { get; set; }
        /// <summary>
	    /// 发信人名称（落款人）
	    /// </summary>
        public string ReceiveUserName { get; set; }
        /// <summary>
	    /// 接收手机号码（多个，用逗号分隔）
	    /// </summary>
        public string ReceiveMobile { get; set; }
        /// <summary>
	    /// 短信内容
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 发送状态（0待发，1已发）
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 发送时间
	    /// </summary>
        public System.DateTime? SendDate { get; set; }

    }
}