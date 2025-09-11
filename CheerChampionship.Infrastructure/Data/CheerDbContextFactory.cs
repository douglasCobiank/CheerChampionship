using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CheerChampionship.Infrastructure.Data
{
    public class CheerDbContextFactory : IDesignTimeDbContextFactory<CheerDbContext>
    {
        public CheerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CheerDbContext>();

            // ⚠️ Substituir pela sua connection string do appsettings.json
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=cheerchampionshipdb;Username=postgres;Password=postgres");

            return new CheerDbContext(optionsBuilder.Options);
        }
    }
}
