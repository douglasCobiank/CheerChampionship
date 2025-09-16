using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Core.Handler.Teams.Models;

namespace CheerChampionship.Core.Handler.Teams
{
    public class TeamHandler : ITeamHandler
    {
        private readonly ITeamService _teamService;

        public TeamHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task CadastraEquipeHandler(Equipe equipe)
        {
            await _teamService.AddEquipeAsync(equipe);
        }

    }
}