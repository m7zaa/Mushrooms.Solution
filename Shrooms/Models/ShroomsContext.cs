using Microsoft.EntityFrameworkCore;

namespace Shrooms.Models
{
    public class ShroomsContext : DbContext
    {
        public ShroomsContext(DbContextOptions<ShroomsContext> options)
            : base(options)
        {
        }

        public DbSet<Mushroom> Mushrooms { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Mushroom>()
            .HasData(
                new Mushroom { MushroomId = 1, Name = "Fly Amanita", Family = "Pluteaceae", Psycho = true, Poisonous = true, Region = "North America, Europe, Asia", SporePrintDetails = "na", VisualDetails = "white stem, red cap with white spots", CapDimensions = 9, StemDimensions = 13 }

            );
        }
    }
}