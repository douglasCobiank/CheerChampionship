using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.Core.Handler.Championships.Services;
using System.Threading.Tasks;

namespace CheerChampionship.Core.Handler
{
    public class CampeonatoHandler : ICampeonatoHandler
    {
        private readonly ICampeonatoService _campeonatoService;

        public CampeonatoHandler(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        public async Task CadastraCampeonatoHandler(Championship campeonato)
        {
            await _campeonatoService.AddCampeonatoAsync(campeonato);
        }

        public void EditaCampeonatoHandler(Championship campeonato)
        {
            
        }

        public void BuscaCampeonatoHandler(string nome, string cidade)
        {
            _campeonatoService.GetCampeonatosAsync();
        }
    }
}