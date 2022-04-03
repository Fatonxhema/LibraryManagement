using System.ComponentModel.DataAnnotations;


namespace LibraryManagement.Models
{
    public class Librarian : User
    {
        [Required]
        public string Department { get; set; }
    }
}
