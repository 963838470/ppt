//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User : BaseDao<User>
    {
        public User()
        {
            this.Sex = 0;
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> Height { get; set; }
    }
}