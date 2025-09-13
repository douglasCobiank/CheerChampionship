using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CheerChampionship.Core.Handler.Teams;
using CheerChampionship.Core.Handler.Teams.Models;
using CheerChampionship.API.Teams.Models;
using CheerChampionship.Core.Handler.Teams.Interface;

namespace CheerChampionship.API.Teams.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamHandler _teamHandler;
        private readonly IMapper _mapper;

        public TeamController(ITeamHandler teamHandler, IMapper mapper)
        {
            _teamHandler = teamHandler;
            _mapper = mapper;
        }

        // POST: api/equipe
        [HttpPost("api/equipe")]
        public IActionResult CriarEquipe([FromBody] Team team)
        {
            var equipeDto = _mapper.Map<Equipe>(team);
            _teamHandler.CadastraEquipeHandler(equipeDto);

            return Ok(new[] { $"Equipe criada"});
        }

    }
}