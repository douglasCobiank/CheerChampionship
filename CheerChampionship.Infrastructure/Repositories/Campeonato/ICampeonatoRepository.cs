using CheerChampionship.Infrastructure.Data.Models;
using System.Threading.Tasks;

namespace CheerChampionship.Infrastructure.Repositories.Campeonato
{
    public interface ICampeonatoRepository
    {
        Task<List<Data.Models.Campeonato>> GetAllAsync();
        Task<Data.Models.Campeonato?> GetByIdAsync(int id);
        Task AddAsync(Data.Models.Campeonato championships);
    }
}