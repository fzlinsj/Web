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
    public partial class ProfitFormulaDetails : Entity
    {
        public ProfitFormulaDetails()
        {
          this.CompanyCD= string.Empty;
          this.SubjectsCD= string.Empty;
          this.SubjectsName= string.Empty;
          this.Direction= string.Empty;
          this.Operator= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FormulaID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SubjectsCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SubjectsName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Direction { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Operator { get; set; }

    }
}