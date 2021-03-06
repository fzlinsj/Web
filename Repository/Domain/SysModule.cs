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
using System.ComponentModel.DataAnnotations.Schema;
using Repository.Core;

namespace Repository.Domain
{
    /// <summary>
    /// 系统模块表
    /// </summary>
    [Table("SysModule")]
    public partial class SysModule : Entity
    {
        public SysModule()
        {
          this.ModuleName= string.Empty;
          this.ModuleType= string.Empty;
          this.PropertyType= string.Empty;
          this.PropertyValue= string.Empty;
          this.ImgPath= string.Empty;
          this.DefaultPage= string.Empty;
          this.ParentID = string.Empty;
        }

        /// <summary>
	    /// 子系统名称
	    /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
	    /// 父模块ID
	    /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// 模块类型
        ///A-表示应用系统
        ///S-表示子系统（六大模块）
        ///M-表示菜单
        ///P-页面
        /// </summary>
        public string ModuleType { get; set; }
        /// <summary>
	    /// 属性类型，主要用于对象更灵活的控制，目前值有：link和空值
	    /// </summary>
        public string PropertyType { get; set; }
        /// <summary>
	    /// 属性值，当属性类型为“link”时，则属性值表示link 内容（如default.aspx）
	    /// </summary>
        public string PropertyValue { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string DefaultPage { get; set; }

    }
}