using Microsoft.EntityFrameworkCore;

namespace Shrooms.Models
{
    public class ShroomsContext : DbContext
    {
        public ShroomsContext(DbContextOptions<ShroomsContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mushroom> Mushrooms { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Mushroom>()
            .HasData(
                new Mushroom { MushroomId = 1, Name = "Fly Amanita", Family = "Pluteaceae", Psycho = true, Poisonous = true, Region = "North America, Europe, Asia", SporePrintDetails = "na", VisualDetails = "white stem, red cap with white spots", CapDimensions = 9, StemDimensions = 13 },
                
                new Mushroom { MushroomId = 2, Name = "Clathrus Ruber", Family = "Stinkhorn", Psycho = false, Poisonous = true, Region = "Southern Europe, Macronesia, Western Turkey, North Africa, Western Asia", SporePrintDetails = "N/A", VisualDetails = "Round or oval hollow sphere, with latticed branches. Red or orange", CapDimensions = 6, StemDimensions = 14 },

                new Mushroom { MushroomId = 3, Name = "Psilocybe cyanescens", Family = "Hymenogastraceae", Psycho = true, Poisonous = false, Region = "Pacific Northwest, Western Europe, Central Europe, New Zealand and west Asia", SporePrintDetails = "blackish-brown to purple", VisualDetails = "Cap is caramel to chestnut-brown when moist, fading to pale buff or slightly yellowish when dried. Stems are wavy. Parts of mushroom can turn blue when touched or disturbed", CapDimensions = 3, StemDimensions = 7 },

                new Mushroom { MushroomId = 4, Name = "Polypore", Family = "Polyporaceae", Psycho = false, Poisonous = false, Region = "Globally in forested areas", SporePrintDetails = "N/A", VisualDetails = "woody, shelf-like form, projecting straight out of tree trunks or logs.", CapDimensions = 29, StemDimensions = 29 }
                
                
            );
        }
    }
}