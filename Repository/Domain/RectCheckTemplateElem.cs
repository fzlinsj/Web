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
    public partial class RectCheckTemplateElem : Entity
    {
        public RectCheckTemplateElem()
        {
          this.CompanyCD= string.Empty;
          this.TemplateNo= string.Empty;
          this.CheckElemID= 0;
          this.MaxScore= 0;
          this.Rate= 0;
          this.Remark= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TemplateNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int CheckElemID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal MaxScore { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }

    }
}