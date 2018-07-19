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
    public partial class EmployeeTraining : Entity
    {
        public EmployeeTraining()
        {
          this.CompanyCD= string.Empty;
          this.TrainingNo= string.Empty;
          this.TrainingName= string.Empty;
          this.ApplyDate= DateTime.Now;
          this.ProjectNo= string.Empty;
          this.ProjectName= string.Empty;
          this.TrainingOrgan= string.Empty;
          this.Goal= string.Empty;
          this.TrainingPlace= string.Empty;
          this.TrainingTeacher= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.TrainingRemark= string.Empty;
          this.CheckPerson= string.Empty;
          this.Attachment= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Status= string.Empty;
          this.AttachmentName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ApplyDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProjectNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingOrgan { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? PlanCost { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TrainingCount { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Goal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingPlace { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? TrainingWay { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingTeacher { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? StartDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? EndDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string TrainingRemark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CheckPerson { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Attachment { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ModifiedDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ModifiedUserID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Status { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AttachmentName { get; set; }

    }
}