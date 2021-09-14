using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLDbContext.Models
{
    public class Acount
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}