using AutoMapper;
using CheerChampionship.Core.Handler.Teams.Models;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Teams.Mappers
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Equipe, EquipeData>();
        }
    }
}