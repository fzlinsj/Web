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
    public partial class SellChancePush : Entity
    {
        public SellChancePush()
        {
          this.CompanyCD= string.Empty;
          this.ChanceNo= string.Empty;
          this.PushDate= DateTime.Now;
          this.Phase= string.Empty;
          this.State= string.Empty;
          this.Remark= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ChanceNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? PushDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Seller { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Phase { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string State { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Feasibility { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? DelayDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }

    }
}