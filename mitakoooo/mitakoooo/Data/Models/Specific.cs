using System.ComponentModel.DataAnnotations;

namespace ImotiScraper.Models
{
    public class Specific
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public List<HousingDeal>? HousingDeals { get; set; }
    }
}
