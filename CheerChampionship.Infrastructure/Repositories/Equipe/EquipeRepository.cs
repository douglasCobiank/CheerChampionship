using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Data;

namespace CheerChampionship.Infrastructure.Repositories.Equipe
{
    public class EquipeRepository : IEquipeRepository
    {
        private readonly CheerDbContext _context;

        public EquipeRepository(CheerDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Data.Models.Equipe equipe)
        {
            _context.Equipes.Add(equipe);
            await _context.SaveChangesAsync();
        }
    }
}