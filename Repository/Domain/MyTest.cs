using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Repository.Core;

namespace Repository.Domain
{
    [Table("MyTest")]
    public partial class MyTest: Entity
    {
        public MyTest()
        {
            this.t1 = string.Empty;
            this.t2 = string.Empty;
           
        }
        public string t1 { get; set; }
        public string t2 { get; set; }
        
    }
}
