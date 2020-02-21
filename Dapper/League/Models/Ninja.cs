using System;
using System.ComponentModel.DataAnnotations;

namespace League.Models
{
    public class Ninja
    {
        [Key]
        public long id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Level must be between 1 and 5")]
        [Display(Name = "Level")]
        public int level { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        [Required]
        [Display(Name = "Dojo")]
        public int dojo_id { get; set; }
        public Dojo dojo { get; set; }
        public string dojo_name { get; set; }

    }
}