using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Athlete
{
    public interface IAthleteRepository
    {
        Task AddAsync(AtletaData atletaData);
        Task EditAsync(AtletaData atletaData);
        Task DeleteAsync(AtletaData atletaData);
        Task<AtletaData> GetByIdAsync(int id);
        Task<IEnumerable<AtletaData>> GetAllAsync();
        Task<AtletaData?> GetByNomeAsync(string nome);
    }
}