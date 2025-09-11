using AutoMapper;
using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Championships.Mappers
{
    public class CampeonatoMapper : Profile
    {
        public CampeonatoMapper()
        {
            CreateMap<Championship, Campeonato>();
        }
    }
}