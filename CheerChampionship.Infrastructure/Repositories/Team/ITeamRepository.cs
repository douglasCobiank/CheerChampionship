using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Team
{
    public interface ITeamRepository
    {
        Task AddAsync(EquipeData equipeData);
        Task EditAsync(EquipeData equipeData);
        Task DeleteAsync(EquipeData equipeData);
        Task<EquipeData> GetByIdAsync(int id);
        Task<IEnumerable<EquipeData>> GetAllAsync();
    }
}