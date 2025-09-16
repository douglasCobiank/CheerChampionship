using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes
{
    public class AthleteHandler(IAthleteService athleteService) : IAthleteHandler
    {
        private readonly IAthleteService _athleteService = athleteService;

        public async Task CadastraAthleteHandler(Atleta atleta)
        {
            await _athleteService.AddAtletaAsync(atleta);
        }

        public async Task DeletaAthletaHandler(Atleta atleta)
        {
            await _athleteService.DeletaAtletaAsync(atleta);
        }

        public async Task EditarAthletaHandler(Atleta atleta)
        {
            await _athleteService.EditarAtletaAsync(atleta);
        }

        public async Task<IEnumerable<Atleta>> GetAllAthletaHandler()
        {
            return await _athleteService.GetAllAtletaAsync();
        }

        public async Task<Atleta> GetAthletaByIdHandler(int id)
        {
            return await _athleteService.GetAtletaByIdAsync(id);
        }
    }
}