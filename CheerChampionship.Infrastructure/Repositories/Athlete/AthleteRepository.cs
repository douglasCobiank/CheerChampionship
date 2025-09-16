using CheerChampionship.Infrastructure.Data;
using CheerChampionship.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CheerChampionship.Infrastructure.Repositories.Athlete
{
    public class AthleteRepository(CheerDbContext context) 
        : Repository<AtletaData>(context), IAthleteRepository
    {
        public async Task<AtletaData?> GetByNomeAsync(string nome)
        {
            return await _dbSet.FirstOrDefaultAsync(a => a.Nome == nome);
        }
    }
}
