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
    
    public partial class Comments
    {
        public int ID { get; set; }
        public int commenterID { get; set; }
        public int articleID { get; set; }
        public string content { get; set; }
        public System.DateTime commentTime { get; set; }
    
        public virtual Articles Articles { get; set; }
        public virtual Users Users { get; set; }
    }
}