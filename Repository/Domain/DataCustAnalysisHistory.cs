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
    public partial class DataCustAnalysisHistory : Entity
    {
        public DataCustAnalysisHistory()
        {
          this.CustNo= string.Empty;
          this.CustName= string.Empty;
          this.CustGrade= string.Empty;
          this.GradeDate= string.Empty;
          this.InsertTime= DateTime.Now;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CustNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustGrade { get; set; }
        /// <summary>
	    /// (1.月,2.季度,3.年)
	    /// </summary>
        public string GradeDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? InsertTime { get; set; }

    }
}