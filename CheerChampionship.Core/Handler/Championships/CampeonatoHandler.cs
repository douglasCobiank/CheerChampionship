using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.Core.Handler.Championships.Services;

namespace CheerChampionship.Core.Handler
{
    public class ChampionshipHandler : IChampionshipHandler
    {
        private readonly IChampionshipService _campeonatoService;

        public ChampionshipHandler(IChampionshipService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        public async Task CadastraChampionshipHandler(Campeonato campeonato)
        {
            await _campeonatoService.AddCampeonatoAsync(campeonato);
        }
    }
}