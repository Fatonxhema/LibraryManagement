using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Student:User
    {
        [Required]
        public string Course { get; set; }
        [Required]
        public string year { get; set; }

    }
}
