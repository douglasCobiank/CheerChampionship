using CheerChampionship.Infrastructure.Data;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Athlete
{
    public class AthleteRepository: IAthleteRepository
    {
        private readonly CheerDbContext _context;

        public AthleteRepository(CheerDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(AtletaData atletaData)
        {
            _context.Atletas.Add(atletaData);
            await _context.SaveChangesAsync();
        }
    }
}