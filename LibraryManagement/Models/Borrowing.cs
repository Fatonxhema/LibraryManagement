using System.ComponentModel.DataAnnotations;


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
