using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multiple_Value_add_Different_Table.Models
{
    [MetadataType(typeof(MetadataStudent))]
    public partial class Student
    {

    }

    public class MetadataStudent
    {

        public string Student_name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

    }
}