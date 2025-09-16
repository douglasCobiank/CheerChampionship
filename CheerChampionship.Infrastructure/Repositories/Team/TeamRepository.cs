using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Data;

namespace CheerChampionship.Infrastructure.Repositories.Team
{
    public class TeamRepository : ITeamRepository
    {
        private readonly CheerDbContext _context;

        public TeamRepository(CheerDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(EquipeData equipe)
        {
            _context.Equipes.Add(equipe);
            await _context.SaveChangesAsync();
        }
    }
}