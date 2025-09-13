using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Core.Handler.Teams.Models;
using CheerChampionship.Infrastructure.Repositories.Equipe;
using CheerChampionship;

using AutoMapper;

namespace CheerChampionship.Core.Handler.Teams.Service
{
    public class TeamService : ITeamService
    {
        private readonly IEquipeRepository _equipeRepository;
        private readonly IMapper _mapper;

        public TeamService(IEquipeRepository equipeRepository, IMapper mapper)
        {
            _equipeRepository = equipeRepository;
            _mapper = mapper;
        }

        public Task AddEquipeAsync(Models.Equipe equipe)
        {
            var teamDto = _mapper.Map<Infrastructure.Data.Models.Equipe>(equipe);
            return _equipeRepository.AddAsync(teamDto);
        }

    }
}