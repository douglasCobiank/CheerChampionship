using CheerChampionship.Core.Handler.Teams.Models;

namespace CheerChampionship.Core.Handler.Teams.Interface
{
    public interface ITeamService
    {
        Task AddEquipeAsync(Equipe equipe);
    }
}