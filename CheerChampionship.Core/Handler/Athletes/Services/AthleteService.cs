using AutoMapper;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;
using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Repositories.Athlete;

namespace CheerChampionship.Core.Handler.Athletes.Services
{
    public class AthleteService(IAthleteRepository athleteRepository, IMapper mapper) : IAthleteService
    {
        private readonly IAthleteRepository _athleteRepository = athleteRepository;
        private readonly IMapper _mapper = mapper;

        public Task AddAtletaAsync(Atleta atleta)
        {
            var atleteData = _mapper.Map<AtletaData>(atleta);
            return _athleteRepository.AddAsync(atleteData);
        }

        public async Task DeletaAtletaAsync(Atleta atleta)
        {
            var atletaResult = await _athleteRepository.GetByNomeAsync(atleta.Nome);

            if (atletaResult is not null)
                await _athleteRepository.DeleteAsync(atletaResult);
        }

        public async Task EditarAtletaAsync(Atleta atleta)
        {
            var atletaResult = await _athleteRepository.GetByNomeAsync(atleta.Nome);

            if (atletaResult is not null)
                await _athleteRepository.EditAsync(atletaResult);
        }

        public async Task<IEnumerable<Atleta>> GetAllAtletaAsync()
        {
            var atleteData = await _athleteRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<Atleta>>(atleteData);
        }

        public async Task<Atleta> GetAtletaByIdAsync(int id)
        {
            var atleteData = await _athleteRepository.GetByIdAsync(id);
            return _mapper.Map<Atleta>(atleteData);
        }
    }
}