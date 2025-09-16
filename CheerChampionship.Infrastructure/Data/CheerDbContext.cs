using Microsoft.EntityFrameworkCore;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Data
{
    public class CheerDbContext : DbContext
    {
        public CheerDbContext(DbContextOptions<CheerDbContext> options)
            : base(options) { }

        public DbSet<CampeonatoData> Campeonatos { get; set; }
        public DbSet<EquipeData> Equipes { get; set; }
        public DbSet<AtletaData> Atletas { get; set; }
        public DbSet<DocumentoData> Documentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // garante explicitamente a PK (útil se o nome for diferente)
            modelBuilder.Entity<CampeonatoData>().HasKey(c => c.Id);
            modelBuilder.Entity<CampeonatoData>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<EquipeData>().HasKey(c => c.Id);
            modelBuilder.Entity<EquipeData>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<AtletaData>().HasKey(c => c.Id);
            modelBuilder.Entity<AtletaData>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<DocumentoData>().HasKey(c => c.Id);
            modelBuilder.Entity<DocumentoData>().Property(e => e.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
