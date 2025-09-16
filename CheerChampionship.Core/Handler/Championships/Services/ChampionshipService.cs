using CheerChampionship.Core.Handler.Championships.Models;
using AutoMapper;
using CheerChampionship.Infrastructure.Repositories.Championship;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Championships.Services
{
    public class ChampionshipService : IChampionshipService
    {
        private readonly IChampionshipRepository _iChampionshipRepository;
        private readonly IMapper _mapper;

        public ChampionshipService(IChampionshipRepository championshipRepository, IMapper mapper)
        {
            _iChampionshipRepository = championshipRepository;
            _mapper = mapper;
        }

        public Task AddCampeonatoAsync(Campeonato championship)
        {
            var camponatoDto = _mapper.Map<CampeonatoData>(championship);
            return _iChampionshipRepository.AddAsync(camponatoDto);
        }
    }
}