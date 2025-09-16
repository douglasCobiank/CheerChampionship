using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes.Interface
{
    public interface IAthleteService
    {
        Task AddAtletaAsync(Atleta atleta);
    }
}