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
    public partial class CurrencyTypeSetting : Entity
    {
        public CurrencyTypeSetting()
        {
          this.CompanyCD= string.Empty;
          this.CurrencyName= string.Empty;
          this.CurrencySymbol= string.Empty;
          this.IsMaster= string.Empty;
          this.ChangeTime= DateTime.Now;
          this.UsedStatus= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CurrencyName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CurrencySymbol { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string IsMaster { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ExchangeRate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ConvertWay { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ChangeTime { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }
        /// <summary>
	    /// 期末汇率
	    /// </summary>
        public decimal? EndRate { get; set; }

    }
}