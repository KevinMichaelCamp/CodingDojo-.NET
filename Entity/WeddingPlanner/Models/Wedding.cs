using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        public string Groom { get; set; }

        [Required]
        public string Bride { get; set; }

        [Required]
        [DataType(DataType.Date)]
        // Validate Future Date
        public DateTime Date { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Address must be at least 5 characters")]
        public string Address { get; set; }
        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User Planner { get; set; }
        public List<Response> Responses { get; set; }
    }

    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public int WeddingId { get; set; }
        public int UserId { get; set; }
        public User Guest { get; set; }
    }
}