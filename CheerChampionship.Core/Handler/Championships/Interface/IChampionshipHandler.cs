using CheerChampionship.Core.Handler.Championships.Models;

namespace CheerChampionship.Core.Handler.Championships.Interface
{
    public interface IChampionshipHandler
    {
        Task CadastraChampionshipHandler(Campeonato campeonato);
    }
}