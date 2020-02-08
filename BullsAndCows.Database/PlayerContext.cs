using Microsoft.EntityFrameworkCore;

namespace BullsAndCows.Database
{
    public class PlayerContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TT4BPFI\SQLEXPRESS01;Database=BullsAndCows;Integrated Security=True");
        }
        public DbSet<Game> Games { get; set; }
    }
}
