using AutoMapper;
using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Championships.Mappers
{
    public class ChampionshipMapper : Profile
    {
        public ChampionshipMapper()
        {
            CreateMap<Campeonato, CampeonatoData>();
        }
    }
}