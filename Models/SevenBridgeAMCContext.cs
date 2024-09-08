using Microsoft.EntityFrameworkCore;

namespace SevenBridgeAMCProj.Models
{
    public class SevenBridgeAMCContext : DbContext
    {
        public SevenBridgeAMCContext(DbContextOptions<SevenBridgeAMCContext> options)
           : base(options)
        { }
        public DbSet<SevenBridgeAMC> SevenBridges { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SevenBridgeAMC>().HasData(
                new SevenBridgeAMC
                {
                    MovieId = 1,
                    Name = "Casablanca",
                    Format = "Standard",
                    Showtime = "16:25",
                    Price = 10,
                },
                new SevenBridgeAMC
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Format = "IMAX",
                    Showtime = "15:00",
                    Price = 9,
                },
                new SevenBridgeAMC
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Format = "Standard",
                    Showtime = "13:00",
                    Price = 7,
                },
                new SevenBridgeAMC
                {
                    MovieId = 4,
                    Name = "Oppenheimer",
                    Format = "IMAX",
                    Showtime = "13:10",
                    Price = 10,
                }
            );
        }

    }
}
