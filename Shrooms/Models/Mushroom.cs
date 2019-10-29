using System.ComponentModel.DataAnnotations;
namespace Shrooms.Models
{
    public class Mushroom
    {
        public int MushroomId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        public bool Psycho { get; set; }
        [Required]
        public bool Poisonous { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string SporePrintDetails { get; set; }
        [Required]
        public string VisualDetails { get; set; }
        [Required]
        public int CapDimensions { get; set; }
        [Required]
        public int StemDimensions { get; set; }

    
    }
}