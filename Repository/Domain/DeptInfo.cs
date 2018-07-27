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
using System.ComponentModel.DataAnnotations.Schema;
using Repository.Core;

namespace Repository.Domain
{
    /// <summary>
	/// 
	/// </summary>
	/// 
    [Table("DeptInfo")]
    public partial class DeptInfo : Entity
    {
        public DeptInfo()
        {
          this.CompanyCD= string.Empty;
          this.DeptNO= string.Empty;
          this.PYshort= string.Empty;
          this.DeptName= string.Empty;
          this.AccountFlag= string.Empty;
          this.Address= string.Empty;
          this.Post= string.Empty;
          this.LinkMan= string.Empty;
          this.Tel= string.Empty;
          this.Fax= string.Empty;
          this.Email= string.Empty;
          this.Duty= string.Empty;
          this.UsedStatus= string.Empty;
          this.Description= string.Empty;
          this.ModifiedDate= DateTime.Now;
          this.ModifiedUserID= string.Empty;
          this.Saleflag= string.Empty;
          this.Subflag= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string CompanyCD { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string DeptNO { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? SuperDeptID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PYshort { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string DeptName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string AccountFlag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Address { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Post { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string LinkMan { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Tel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Fax { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Email { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Duty { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string UsedStatus { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Description { get; set; }
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
        public string Saleflag { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Subflag { get; set; }

    }
}