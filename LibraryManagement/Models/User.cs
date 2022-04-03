using System.ComponentModel.DataAnnotations;


namespace LibraryManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(3)]
        public int Age { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

    }
}
