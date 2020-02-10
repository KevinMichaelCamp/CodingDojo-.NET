using System.ComponentModel.DataAnnotations;

namespace Trails.Models
{
    public class Trail
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Description must be at least 10 characters")]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Length must be positive")]
        public double Length { get; set; }

        [Required]
        [Display(Name = "Elevation Change")]
        public int Elevation_Change { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
    }
}