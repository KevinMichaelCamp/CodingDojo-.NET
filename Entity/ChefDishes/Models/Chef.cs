using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "First name must be at least 3 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last name must be at least 3 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        // Validate over 18
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> CreatedDishes { get; set; }
    }
}