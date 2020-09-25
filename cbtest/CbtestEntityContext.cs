using System;
using Microsoft.EntityFrameworkCore;

namespace cbtest
{
    public class CbtestEntityContext : DbContext
    {
        public CbtestEntityContext(DbContextOptions<CbtestEntityContext> options) : base(options)
        {
        }
        public DbSet<CbtestEntity> Cbtests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CbtestEntity>()
                .HasKey(aa => new { aa.CbtestEntityId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
