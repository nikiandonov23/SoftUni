using System.ComponentModel.DataAnnotations;

namespace ImotiScraper.Models
{
    public class HousingDeal
    {
       public int Id { get; set; }
       public string? Type { get; set; }
       public int LocationId { get; set; }
       public Location? Location { get; set; } = new Location();
       public int RegionId { get; set; }
       public Region? Region { get; set; } = new Region();
       public string? SquareMeteres { get; set; }  
       public int? Floor { get; set; }
       public bool? GasHeating { get; set; }
       public bool? CentralHeating { get; set; }
       public string? ConstructionType { get; set; }  
       public List<Specific>? Specifics { get; set; } = new List<Specific>();
       public int? Yard { get; set; }
       public string? UsageSpecifics { get; set; }
       public string? Category { get; set; }
       public decimal? Price { get; set; }
       public int? Views { get; set; }
       public string? Link { get; set; }
       public string? Other { get; set; }




      

     
    }
}
