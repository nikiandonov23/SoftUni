using System.ComponentModel.DataAnnotations;

namespace ImotiScraper.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Region>? Regions { get; set; }
        public ICollection<HousingDeal>? HousingDeals { get; set; }
    }
}
