using AutoMapper;
using CheerChampionship.Core.Handler.Teams.Models;
using CheerChampionship;

namespace CheerChampionship.Core.Handler.Teams.Mappers
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Models.Equipe, Infrastructure.Data.Models.Equipe>();
        }
    }
}