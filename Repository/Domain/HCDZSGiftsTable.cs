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
    public partial class HCDZSGiftsTable : Entity
    {
        public HCDZSGiftsTable()
        {
          this.Id= 0;
          this.Summaryperson= string.Empty;
          this.SummaryMonth= string.Empty;
          this.SummaryDate= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Pid { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Summaryperson { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SummaryMonth { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? SummaryDate { get; set; }

    }
}