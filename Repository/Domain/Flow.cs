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
    public partial class Flow : Entity
    {
        public Flow()
        {
          this.CompanyCD= string.Empty;
          this.FlowNo= string.Empty;
          this.FlowName= string.Empty;
          this.BillTypeID= string.Empty;
          this.BillTypeName= string.Empty;
          this.UsedStatus= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.IsMobileNotice= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FlowNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string FlowName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? BillTypeFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? BillTypeCode { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BillTypeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BillTypeName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 是否手机短信提醒（0否，1是）
	    /// </summary>
        public string IsMobileNotice { get; set; }

    }
}