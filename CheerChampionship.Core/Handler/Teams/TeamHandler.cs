using CheerChampionship.Core.Handler.Teams;
using System.Threading.Tasks;
using CheerChampionship.Core.Handler.Teams.Interface;

namespace CheerChampionship.Core.Handler.Teams
{
    public class TeamHandler : ITeamHandler
    {
        private readonly ITeamService _teamService;

        public TeamHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task CadastraEquipeHandler(Models.Equipe equipe)
        {
            await _teamService.AddEquipeAsync(equipe);
        }

    }
}