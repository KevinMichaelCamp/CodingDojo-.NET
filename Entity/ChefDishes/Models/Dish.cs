using System;
using System.ComponentModel.DataAnnotations;

namespace ChefDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Dish name must be at least 3 characters")]
        public string Name { get; set; }

        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Calories must be positive number")]
        public int Calories { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Tastiness must be value 1-5")]
        public int Tastiness { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Chef")]
        public int ChefId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Chef CreatedBy { get; set; }
    }
}