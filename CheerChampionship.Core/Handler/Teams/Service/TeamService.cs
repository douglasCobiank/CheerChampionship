using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Infrastructure.Repositories.Team;
using AutoMapper;
using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Core.Handler.Teams.Models;

namespace CheerChampionship.Core.Handler.Teams.Service
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public Task AddEquipeAsync(Equipe equipe)
        {
            var teamDto = _mapper.Map<EquipeData>(equipe);
            return _teamRepository.AddAsync(teamDto);
        }

    }
}