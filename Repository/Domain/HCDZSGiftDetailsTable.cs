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
    public partial class HCDZSGiftDetailsTable : Entity
    {
        public HCDZSGiftDetailsTable()
        {
          this.Id= 0;
          this.MarketPlaceName= string.Empty;
          this.GiftName= string.Empty;
          this.GiftPrice= string.Empty;
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
        public string MarketPlaceName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string GiftName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string GiftPrice { get; set; }

    }
}