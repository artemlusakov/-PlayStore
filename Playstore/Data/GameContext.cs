using Microsoft.EntityFrameworkCore;
using Playstore.Models;

namespace Playstore.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
        {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SaleGame> SaleGames { get; set; }
        public DbSet<Developer> Developers { get; set; }
        }
    }
}
