using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using ElectronicIdentityApp.DataModels;


namespace ElectronicIdentityApp.Data

{

    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<IdentityUser>(options)
    {
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;

        public DbSet<Nationality> Nationalities { get; set; } = null!;

        public DbSet<UserAddress> UsersAddresses { get; set; } = null!;
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;
    }

}
