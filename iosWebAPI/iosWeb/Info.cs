//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace iosWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Info
    {
        public Info()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int ID { get; set; }
        public bool sex { get; set; }
        public string introduce { get; set; }
        public System.DateTime birthday { get; set; }
        public string email { get; set; }
        public string QQ { get; set; }
        public System.DateTime signtime { get; set; }
    
        public virtual ICollection<Users> Users { get; set; }
    }
}