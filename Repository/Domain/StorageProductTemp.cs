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
    public partial class StorageProductTemp : Entity
    {
        public StorageProductTemp()
        {
          this.企业编号= string.Empty;
          this.仓库= string.Empty;
          this.批次= string.Empty;
          this.物品= string.Empty;
          this.现有存量= string.Empty;
          this.物品编号= string.Empty;
          this.单价= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? 流水号 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 企业编号 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 仓库 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 批次 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 物品 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 现有存量 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 物品编号 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string 单价 { get; set; }

    }
}