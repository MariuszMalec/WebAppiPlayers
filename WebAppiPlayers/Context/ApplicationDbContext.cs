using Microsoft.EntityFrameworkCore;
using WebAppiPlayers.Entities;
using WebAppiPlayers.Models;

namespace WebAppiPlayers.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u=>u.Email)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .Property(u=>u.Name)
                .IsRequired();
        }
    }
}
