using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.API.Championship.Models;
using Microsoft.AspNetCore.Mvc;
using CheerChampionship.API.Championship.Mappers;
using AutoMapper;
using CheerChampionship.Core.Handler.Championships.Models;

namespace CheerChampionship.API.Championship.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampeonatosController : ControllerBase
    {
        private readonly ICampeonatoHandler _campeonatoHandler;
        private readonly IMapper _mapper;

        public CampeonatosController(ICampeonatoHandler campeonatoHandler, IMapper mapper)
        {
            _campeonatoHandler = campeonatoHandler;
            _mapper = mapper;
        }

        // POST: api/campeonatos
        [HttpPost("api/campeonatos")]
        public IActionResult CriarCampeonato([FromBody] Campeonato campeonato)
        {
            var campeonatoDto = _mapper.Map<Championship>(campeonato);
            _campeonatoHandler.CadastraCampeonatoHandler(campeonatoDto);

            return Ok(new[] { $"Campeonato criado"});
        }

        // PUT: api/campeonatos/{id}
        [HttpPut("api/campeonatos/{id}")]
        public IActionResult EditarCampeonato(Guid id, [FromBody] Campeonato campeonato)
        {
            var campeonatoDto = _mapper.Map<Championship>(campeonato);
            _campeonatoHandler.EditaCampeonatoHandler(campeonatoDto);

            return Ok($"Campeonato '{campeonatoDto.Name}' editado com sucesso!");
        }

        // GET: api/campeonatos/buscar?nome=X&cidade=Y
        [HttpGet("api/campeonatos/buscar")]
        public IActionResult BuscarCampeonato([FromQuery] string nome, [FromQuery] string cidade)
        {
            _campeonatoHandler.BuscaCampeonatoHandler(nome, cidade);
            return Ok();
        }
    }
}
