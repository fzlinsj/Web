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
    public partial class FlowStepActor : Entity
    {
        public FlowStepActor()
        {
          this.CompanyCD= string.Empty;
          this.FlowNo= string.Empty;
          this.StepNo= 0;
          this.StepName= string.Empty;
          this.Actor= 0;
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
        public string FlowNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int StepNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string StepName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int Actor { get; set; }
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