using Microsoft.EntityFrameworkCore;

namespace Shrooms.Models
{
    public class ShroomsContext : DbContext
    {
        public ShroomsContext(DbContextOptions ShroomsContext> options)
            : base(options)
        {
        }

        public DbSet<Mushroom> Mushrooms { get; set; }
    }
}