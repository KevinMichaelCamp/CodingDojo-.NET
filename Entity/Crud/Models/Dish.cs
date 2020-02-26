using System;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Dish name must be at least 3 characters")]
        [Display(Name = "Dish Name")]
        public string Name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Chef name must be at least 3 characters")]
        [Display(Name = "Chef Name")]
        public string Chef { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Tastiness rating must be between 1 & 5")]
        public int Tastiness { get; set; }

        [Required]
        [Range(0, Int16.MaxValue, ErrorMessage = "Calorie value must be positive")]
        public int Calories { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}