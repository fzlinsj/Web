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
    public partial class ProjectBaseNum : Entity
    {
        public ProjectBaseNum()
        {
          this.CompanyCD= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public long Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ProjectID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SummaryID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? BaseNum { get; set; }

    }
}