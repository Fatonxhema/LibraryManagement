using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Borrowing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Bookname { get; set; }
        [Required]
        [MaxLength(25)]
        public string Borrower { get; set; }
        [Required]
        [MaxLength(15)]
        public string DateBorrowed { get; set; }
        [Required]
        [MaxLength(15)]
        public string DateDue { get; set; }

    }
}
