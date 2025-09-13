using Microsoft.EntityFrameworkCore;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Data
{
    public class CheerDbContext : DbContext
    {
        public CheerDbContext(DbContextOptions<CheerDbContext> options)
            : base(options) { }

        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Equipe> Equipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // garante explicitamente a PK (útil se o nome for diferente)
            modelBuilder.Entity<Campeonato>().HasKey(c => c.Id);
            modelBuilder.Entity<Campeonato>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Equipe>().HasKey(c => c.Id);
            modelBuilder.Entity<Equipe>().Property(e => e.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
