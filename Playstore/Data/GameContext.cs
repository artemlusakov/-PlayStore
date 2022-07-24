using Microsoft.EntityFrameworkCore;
using Playstore.Models;

namespace Playstore.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<SaleGame> SaleGames { get; set; } = null!;
        public DbSet<Developer> Developers { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Role)
                .WithMany()
                .HasForeignKey(s => s.RoleID);

            modelBuilder.Entity<Game>()
                .HasOne(q => q.Developer)
                .WithMany()
                .HasForeignKey(w => w.DeveloperID);

            modelBuilder.Entity<Game>()
                .HasOne(e => e.Genre)
                .WithMany()
                .HasForeignKey(z => z.GenreID);

            modelBuilder.Entity<SaleGame>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(t => t.UserID);

            modelBuilder.Entity<SaleGame>()
                .HasOne(y => y.Game)
                .WithMany()
                .HasForeignKey(u => u.GameID);
            modelBuilder.Entity<SaleGame>().HasNoKey();
        }
        
    }
}
