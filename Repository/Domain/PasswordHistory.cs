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
	/// 用户密码修改记录表。用户修改密码历史日志。
	/// </summary>
    public partial class PasswordHistory : Entity
    {
        public PasswordHistory()
        {
          this.CompanyCD= string.Empty;
          this.UserID= string.Empty;
          this.Password= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 企业代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 登录用户
	    /// </summary>
        public string UserID { get; set; }
        /// <summary>
	    /// 密码
	    /// </summary>
        public string Password { get; set; }
        /// <summary>
	    /// 密码修改时间
	    /// </summary>
        public System.DateTime ModifiedDate { get; set; }
        /// <summary>
	    /// 最后更新用户ID
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}