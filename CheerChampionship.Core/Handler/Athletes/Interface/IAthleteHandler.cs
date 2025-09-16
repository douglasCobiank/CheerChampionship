using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes.Interface
{
    public interface IAthleteHandler
    {
        Task CadastraAthleteHandler(Atleta atleta);
    }
}