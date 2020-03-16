using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public User WedderOne { get; set; }
        public User WedderTwo { get; set; }
        public User Guest { get; set; }
        public Wedding Wedding { get; set; }
    }
}