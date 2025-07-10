using System.ComponentModel.DataAnnotations;

namespace ImotiScraper.Models
{
    public class Region
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)] 
        public string? Name { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public ICollection<HousingDeal>? HousingDeals { get; set; }
    }
}
