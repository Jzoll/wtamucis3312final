using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class FinalDbContext : DbContext
    {
        public FinalDbContext(DbContextOptions<FinalDbContext> options)
            : base(options) { }

        // This is for the Many to Many relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<UserNationalParks>()
                .HasKey(s => new { s.NationalParkId, s.UserDataId });
        }

        public DbSet<NationalPark> NationalParks { get; set; } = default!;
        public DbSet<UserNationalParks> UserNationalParks { get; set; } = default!;
        public DbSet<UserData> UserData { get; set; } = default!;
    }
}
