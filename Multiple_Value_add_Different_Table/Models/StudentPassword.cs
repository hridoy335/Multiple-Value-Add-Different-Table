//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multiple_Value_add_Different_Table.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentPassword
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
