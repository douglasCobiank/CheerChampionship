using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Team
{
    public interface ITeamRepository
    {
        Task AddAsync(EquipeData equipe);
    }
}