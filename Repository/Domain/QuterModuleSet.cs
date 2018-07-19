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
    public partial class QuterModuleSet : Entity
    {
        public QuterModuleSet()
        {
          this.CompanyCD= string.Empty;
          this.QuarterNo= string.Empty;
          this.ModuleID= string.Empty;
        }

        /// <summary>
	    /// 公司代码
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 部门ID
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 岗位编号
	    /// </summary>
        public string QuarterNo { get; set; }
        /// <summary>
	    /// 关联模块ID
	    /// </summary>
        public string ModuleID { get; set; }
        /// <summary>
	    /// 开启的模块中分类类型
	    /// </summary>
        public int? TypeID { get; set; }
        /// <summary>
	    /// 1 为岗位说明书模块设置 2 新建岗位模块设置
	    /// </summary>
        public int? Sign { get; set; }
        /// <summary>
	    /// 岗位说明书ID 
	    /// </summary>
        public int? QuterDescribID { get; set; }

    }
}