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
    public partial class FeeReturnDetail : Entity
    {
        public FeeReturnDetail()
        {
          this.Notes= string.Empty;
          this.SubjectsNo= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? SortNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ExpID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ReimbID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ExpAmount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? ReimbAmount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? RestoreAmount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Notes { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FeeNameID { get; set; }
        /// <summary>
	    /// 科目编号
	    /// </summary>
        public string SubjectsNo { get; set; }

    }
}