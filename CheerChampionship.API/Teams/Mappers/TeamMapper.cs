using CheerChampionship.API.Teams.Models;
using AutoMapper;
using CheerChampionship.Core.Handler.Teams.Models;

namespace CheerChampionship.API.Teams.Mappers
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Team, Equipe>().ReverseMap();
        }
    }
}