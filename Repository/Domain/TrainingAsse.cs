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
    public partial class TrainingAsse : Entity
    {
        public TrainingAsse()
        {
          this.CompanyCD= string.Empty;
          this.AsseNo= string.Empty;
          this.TrainingNo= string.Empty;
          this.CheckPerson= string.Empty;
          this.TrainingPlan= string.Empty;
          this.LeadViews= string.Empty;
          this.Description= string.Empty;
          this.CheckWay= string.Empty;
          this.CheckDate= DateTime.Now;
          this.GeneralComment= string.Empty;
          this.CheckRemark= string.Empty;
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
        public string AsseNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CheckPerson { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingPlan { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FillUser { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string LeadViews { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CheckWay { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CheckDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string GeneralComment { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CheckRemark { get; set; }
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