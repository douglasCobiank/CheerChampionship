using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship;
using AutoMapper;
using CheerChampionship.Infrastructure.Repositories.Campeonato;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Championships.Services
{
    public class CampeonatoService : ICampeonatoService
    {
        private readonly ICampeonatoRepository _campeonatoRepository;
        private readonly IMapper _mapper;

        public CampeonatoService(ICampeonatoRepository campeonatoRepository, IMapper mapper)
        {
            _campeonatoRepository = campeonatoRepository;
            _mapper = mapper;
        }

        public Task<List<Championship>> GetCampeonatosAsync()
        {
            return null;
        }

        public Task<Championship?> GetCampeonatoPorIdAsync(int id)
        {
            return null;
        }

        public Task AddCampeonatoAsync(Championship championship)
        {
            var camponatoDto = _mapper.Map<Campeonato>(championship);
            return _campeonatoRepository.AddAsync(camponatoDto);
        }
    }
}