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
	/// 系统参数表
	/// </summary>
    public partial class SysParam : Entity
    {
        public SysParam()
        {
          this.IndexType= string.Empty;
          this.IndexCode= string.Empty;
          this.IndexValue= string.Empty;
          this.Remark= string.Empty;
        }

        /// <summary>
	    /// 参数类型
	    /// </summary>
        public string IndexType { get; set; }
        /// <summary>
	    /// 参数编号
	    /// </summary>
        public int? IndexNum { get; set; }
        /// <summary>
	    /// 参数代码
	    /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
	    /// 参数值
	    /// </summary>
        public string IndexValue { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Remark { get; set; }

    }
}