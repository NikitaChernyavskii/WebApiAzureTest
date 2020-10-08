using System.ComponentModel.DataAnnotations.Schema;
using AzureWebTestDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureWebTestDb.Contexts
{
    public class AzureWebTestAppTantiDbContext : DbContext
    {
        public AzureWebTestAppTantiDbContext()
        {
        }

        public AzureWebTestAppTantiDbContext(DbContextOptions<AzureWebTestAppTantiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");
            });
        }
    }
}
