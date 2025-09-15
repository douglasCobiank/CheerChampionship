using CheerChampionship.Core.Handler.Teams.Models;

namespace CheerChampionship.Core.Handler.Teams.Interface
{
    public interface ITeamHandler
    {
        Task CadastraEquipeHandler(Equipe equipe);
    }
}