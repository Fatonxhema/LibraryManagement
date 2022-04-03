using System.ComponentModel.DataAnnotations;


namespace LibraryManagement.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Date { get; set; }

    }
}
