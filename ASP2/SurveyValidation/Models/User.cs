using System.ComponentModel.DataAnnotations;

namespace SurveyValidation.Models
{
    public class User
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Dojo Location")]
        public string Location { get; set; }
        [Required]
        [Display(Name = "Favorite Langauge")]
        public string Language { get; set; }
        [MaxLength(20, ErrorMessage = "Comment must be less than 20 characters")]
        [Display(Name = "Comment (optional)")]
        public string Comment { get; set; }
    }
}