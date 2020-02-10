using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }
    }
}