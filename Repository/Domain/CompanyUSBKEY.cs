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
    public partial class CompanyUSBKEY : Entity
    {
        public CompanyUSBKEY()
        {
          this.CompanyCD= string.Empty;
          this.Usbkey= string.Empty;
          this.Status= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Usbkey { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }

    }
}