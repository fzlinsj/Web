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
    public partial class RelationTable : Entity
    {
        public RelationTable()
        {
          this.Id= 0;
          this.Relation= string.Empty;
          this.ColumnID= 0;
          this.Tableid= 0;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Relation { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int ColumnID { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int Tableid { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? Summaryflag { get; set; }

    }
}