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
    public partial class DataRelation : Entity
    {
        public DataRelation()
        {
          this.RelationKeyName= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public int? ActionId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? KeyWordId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string RelationKeyName { get; set; }

        public virtual DataAction ActionDataAction { get; set; }
        public virtual DataKeyWord KeyWordDataKeyWord { get; set; }
    }
}