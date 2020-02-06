using System.ComponentModel.DataAnnotations;

namespace LoginRegister.Models
{
    public class LogUser
    {
        [Required]
        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}