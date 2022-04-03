using System.ComponentModel.DataAnnotations;


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
