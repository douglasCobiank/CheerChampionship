using AutoMapper;
using CheerChampionship.API.AthletesModels.Models;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheerChampionship.API.Athletes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AthletesController : ControllerBase
    {
        private readonly IAthleteHandler _athletesHandler;
        private readonly IMapper _mapper;

        public AthletesController(IAthleteHandler athletesHandler, IMapper mapper)
        {
            _athletesHandler = athletesHandler;
            _mapper = mapper;
        }

        // POST: api/campeonatos
        [HttpPost("cadastrar")]
        public IActionResult CriarCampeonato([FromBody] AtletaDto atleta)
        {
            var atletaDto = _mapper.Map<Atleta>(atleta);
            _athletesHandler.CadastraAthleteHandler(atletaDto);

            return Ok(new[] { $"Campeonato criado" });
        }
    }
}