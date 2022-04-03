using System.ComponentModel.DataAnnotations;


namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Title { get; set; }
        public string Details { get; set; }
        [Required]
        public string Publisher { get; set; }

    }
}
