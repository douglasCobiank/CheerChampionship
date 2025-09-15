using AutoMapper;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;
using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Repositories.Athlete;

namespace CheerChampionship.Core.Handler.Athletes
{
    public class AthleteService : IAthleteService
    {
        private readonly IAthleteRepository _athleteRepository;
        private readonly IMapper _mapper;

        public AthleteService(IAthleteRepository athleteRepository, IMapper mapper)
        {
            _athleteRepository = athleteRepository;
            _mapper = mapper;
        }

        public Task AddAtletaAsync(Atleta atleta)
        {
            var atleteData = _mapper.Map<AtletaData>(atleta);
            return _athleteRepository.AddAsync(atleteData);
        }
    }
}