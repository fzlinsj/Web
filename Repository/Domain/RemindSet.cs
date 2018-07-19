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
    public partial class RemindSet : Entity
    {
        public RemindSet()
        {
          this.CompanyCD= string.Empty;
          this.IsMobileNotice= string.Empty;
          this.Mobile= string.Empty;
          this.RemindTime= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 公司编码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 提醒类型(1： 库存限量报警;2：客户联络延期告警；3：供应商联络延期告警;4：即将到期的劳动合同；5：办公用品缺货预警；6：费用报销延期预警)
	    /// </summary>
        public int? RemindType { get; set; }
        /// <summary>
	    /// 是否手机短信提醒（0否，1是）
	    /// </summary>
        public string IsMobileNotice { get; set; }
        /// <summary>
	    /// 手机号(多个号码用逗号分开,最多可设4个号码)
	    /// </summary>
        public string Mobile { get; set; }
        /// <summary>
	    /// 提醒周期(1:天 2:周 3:月)
	    /// </summary>
        public int? RemindPeriod { get; set; }
        /// <summary>
	    /// 按天：第几天(隔几天发一次)
	    /// </summary>
        public int? SubPeriod { get; set; }
        /// <summary>
	    /// 提醒时间点
	    /// </summary>
        public string RemindTime { get; set; }
        /// <summary>
	    /// 最后更新日期
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID(对应操作用户UserID)
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}