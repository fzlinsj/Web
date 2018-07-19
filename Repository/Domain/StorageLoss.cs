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
    public partial class StorageLoss : Entity
    {
        public StorageLoss()
        {
          this.Id= 0;
          this.CompanyCD= string.Empty;
          this.LossNo= string.Empty;
          this.Title= string.Empty;
          this.LossDate= DateTime.Now;
          this.Summary= string.Empty;
          this.Remark= string.Empty;
          this.Attachment= string.Empty;
          this.CreateDate= DateTime.Now;
          this.BillStatus= string.Empty;
          this.ConfirmDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.ExtField1= string.Empty;
          this.ExtField2= string.Empty;
          this.ExtField3= string.Empty;
          this.ExtField4= string.Empty;
          this.ExtField5= string.Empty;
          this.ExtField6= string.Empty;
          this.ExtField7= string.Empty;
          this.ExtField8= string.Empty;
          this.ExtField9= string.Empty;
          this.ExtField10= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string LossNo { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Title { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Executor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? DeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? StorageID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? ReasonType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? LossDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public decimal? CountTotal { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Summary { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Remark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Attachment { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Creator { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string BillStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Confirmor { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? ConfirmDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Closer { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime? CloseDate { get; set; }
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
        public string ExtField1 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField2 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField3 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField4 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField5 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField6 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField7 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField8 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField9 { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ExtField10 { get; set; }

    }
}