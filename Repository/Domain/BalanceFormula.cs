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
    public partial class BalanceFormula : Entity
    {
        public BalanceFormula()
        {
          this.Name= string.Empty;
        }

        /// <summary>
	    /// 资产负债表项目
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 行次
	    /// </summary>
        public int? Line { get; set; }

    }
}