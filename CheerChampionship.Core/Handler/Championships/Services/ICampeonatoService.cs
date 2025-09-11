using CheerChampionship.Core.Handler.Championships.Models;

namespace CheerChampionship.Core.Handler.Championships.Services
{
    public interface ICampeonatoService
    {
        Task<List<Championship>> GetCampeonatosAsync();
        Task<Championship?> GetCampeonatoPorIdAsync(int id);
        Task AddCampeonatoAsync(Championship championship);
    }
}