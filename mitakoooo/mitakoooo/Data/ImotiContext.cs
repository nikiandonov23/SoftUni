using ImotiScraper.Models;
using Microsoft.EntityFrameworkCore;

namespace ImotiScraper.Database
{
    public class ImotiContext : DbContext
    {
        public ImotiContext() : base()
        {
        }

        public DbSet<HousingDeal> HousingDeals { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Specific> Specifics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specific>()
                .HasIndex(s => s.Name)
                .IsUnique();

            modelBuilder.Entity<Region>()
                   .HasOne(r => r.Location)
                   .WithMany(l => l.Regions)
                   .HasForeignKey(r => r.LocationId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HousingDeal>()
               .HasMany(h => h.Specifics)
               .WithMany(s => s.HousingDeals)
               .UsingEntity(j => j.ToTable("HousingDealSpecifics"));

            modelBuilder.Entity<HousingDeal>()
                        .HasMany(h => h.Specifics)
                        .WithMany(s => s.HousingDeals)
                        .UsingEntity<Dictionary<string, object>>(
                         "HousingDealSpecifics",  
                         j => j.HasOne<Specific>()
                        .WithMany()
                        .HasForeignKey("SpecificId")
                        .OnDelete(DeleteBehavior.Restrict),  
                         j => j.HasOne<HousingDeal>()
                        .WithMany()
                        .HasForeignKey("HousingDealId")
                        .OnDelete(DeleteBehavior.Cascade));

            modelBuilder.Entity<HousingDeal>()
                        .HasOne(h => h.Region)
                        .WithMany(r => r.HousingDeals) 
                        .HasForeignKey(h => h.RegionId)
                        .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ImotiDb;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
