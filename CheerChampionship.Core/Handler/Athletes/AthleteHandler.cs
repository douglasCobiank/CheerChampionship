using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes
{
    public class AthleteHandler: IAthleteHandler
    {
        private readonly IAthleteService _athleteService;

        public AthleteHandler(IAthleteService athleteService)
        {
            _athleteService = athleteService;
        }

        public async Task CadastraAthleteHandler(Atleta atleta)
        {
            await _athleteService.AddAtletaAsync(atleta);
        }
    }
}