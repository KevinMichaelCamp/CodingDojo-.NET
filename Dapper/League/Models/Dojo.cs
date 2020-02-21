using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace League.Models
{
    public class Dojo
    {
        [Key]
        public long id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Location must be at least 3 characters")]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        public IEnumerable<Ninja> ninjas { get; set; }

        public Dojo()
        {
            ninjas = new List<Ninja>();
        }
    }
}