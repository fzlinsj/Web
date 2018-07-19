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
    public partial class EndItemProcessedRecord : Entity
    {
        public EndItemProcessedRecord()
        {
          this.CompanyCD= string.Empty;
          this.PeriodNum= string.Empty;
          this.CreateDate= DateTime.Now;
          this.IsAccount= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 期末项目ID
	    /// </summary>
        public int? ItemID { get; set; }
        /// <summary>
	    /// 期数
	    /// </summary>
        public string PeriodNum { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsAccount { get; set; }

        public virtual EndItemProcSetting ItemEndItemProcSetting { get; set; }
    }
}