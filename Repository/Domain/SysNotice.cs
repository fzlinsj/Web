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
    public partial class SysNotice : Entity
    {
        public SysNotice()
        {
          this.Title= string.Empty;
          this.Content= string.Empty;
          this.PubDate= DateTime.Now;
          this.OverDate= DateTime.Now;
          this.CreatorUserID= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? PubDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? OverDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CreatorUserID { get; set; }

    }
}