using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLDbContext.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string NameStudent { get; set; }
        public string Address { get; set; }

    }
}