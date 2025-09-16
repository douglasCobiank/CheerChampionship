using AutoMapper;
using CheerChampionship.API.AthletesModels.Models;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheerChampionship.API.Athletes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AthletesController(IAthleteHandler athletesHandler, IMapper mapper) : ControllerBase
    {
        private readonly IAthleteHandler _athletesHandler = athletesHandler;
        private readonly IMapper _mapper = mapper;

        // POST: api/campeonatos
        [HttpPost("cadastrar")]
        public IActionResult CriarAtleta([FromBody] AtletaDto atleta)
        {
            var atletaDto = _mapper.Map<Atleta>(atleta);
            _athletesHandler.CadastraAthleteHandler(atletaDto);

            return Ok(new[] { $"Atleta criado" });
        }

        [HttpPost("editar")]
        public IActionResult EditarAtleta([FromBody] AtletaDto atleta)
        {
            var atletaDto = _mapper.Map<Atleta>(atleta);
            _athletesHandler.EditarAthletaHandler(atletaDto);

            return Ok(new[] { $"Atleta editado" });
        }

        [HttpPost("deletar")]
        public IActionResult DeletarAtleta([FromBody] AtletaDto atleta)
        {
            var atletaDto = _mapper.Map<Atleta>(atleta);
            _athletesHandler.DeletaAthletaHandler(atletaDto);

            return Ok(new[] { $"Atleta deletado" });
        }

        [HttpPost("buscaId")]
        public async Task<Atleta> BuscaAtletaPorId([FromBody] int id)
        {
            return await _athletesHandler.GetAthletaByIdHandler(id);
        }

        [HttpPost("buscaAtletas")]
        public async Task<IEnumerable<Atleta>> BuscaAtleta()
        {
            return await _athletesHandler.GetAllAthletaHandler();
        }
    }
}