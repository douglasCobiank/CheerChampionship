using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Championship
{
    public interface IChampionshipRepository
    {
        Task<List<CampeonatoData>> GetAllAsync();
        Task<CampeonatoData?> GetByIdAsync(int id);
        Task AddAsync(CampeonatoData championships);
    }
}