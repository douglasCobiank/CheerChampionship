using CheerChampionship.Core.Handler.Championships.Models;

namespace CheerChampionship.Core.Handler.Championships.Services
{
    public interface IChampionshipService
    {
        Task AddCampeonatoAsync(Campeonato championship);
    }
}