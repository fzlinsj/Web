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
    public partial class SubscribeHistory : Entity
    {
        public SubscribeHistory()
        {
          this.CompanyCD= string.Empty;
          this.Receiver= string.Empty;
          this.InfoID= 0;
          this.SendDate= DateTime.Now;
          this.KeyWordID= string.Empty;
          this.KeyWordName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? RootID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Receiver { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int InfoID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime SendDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string KeyWordID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string KeyWordName { get; set; }

    }
}