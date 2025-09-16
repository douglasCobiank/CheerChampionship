using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Championship
{
    public interface IChampionshipRepository
    {
        Task AddAsync(CampeonatoData campeonatoData);
        Task EditAsync(CampeonatoData campeonatoData);
        Task DeleteAsync(CampeonatoData campeonatoData);
        Task<CampeonatoData> GetByIdAsync(int id);
        Task<IEnumerable<CampeonatoData>> GetAllAsync();
    }
}