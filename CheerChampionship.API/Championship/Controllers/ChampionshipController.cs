using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.API.Championship.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CheerChampionship.Core.Handler.Championships.Models;

namespace CheerChampionship.API.Championship.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChampionshipController : ControllerBase
    {
        private readonly IChampionshipHandler _championshipHandler;
        private readonly IMapper _mapper;

        public ChampionshipController(IChampionshipHandler championshipHandler, IMapper mapper)
        {
            _championshipHandler = championshipHandler;
            _mapper = mapper;
        }

        // POST: api/campeonatos
        [HttpPost("cadastrar")]
        public IActionResult CriarCampeonato([FromBody] CampeonatoDto campeonato)
        {
            var campeonatoDto = _mapper.Map<Campeonato>(campeonato);
            _championshipHandler.CadastraChampionshipHandler(campeonatoDto);

            return Ok(new[] { $"Campeonato criado"});
        }
    }
}
