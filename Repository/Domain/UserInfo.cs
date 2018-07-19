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
	/// 员工表
	/// </summary>
    public partial class UserInfo : Entity
    {
        public UserInfo()
        {
          this.CompanyCD= string.Empty;
          this.Password= string.Empty;
          this.UsedStatus= string.Empty;
          this.LockFlag= string.Empty;
          this.OpenDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Remark= string.Empty;
          this.IsRoot= string.Empty;
          this.LastLoginTime= DateTime.Now;
          this.IsHardValidate= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Password { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string LockFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? OpenDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CloseDate { get; set; }
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
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsRoot { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? LastLoginTime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsHardValidate { get; set; }

    }
}