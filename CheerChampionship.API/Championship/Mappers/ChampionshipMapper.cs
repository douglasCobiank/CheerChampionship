using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.API.Championship.Models;
using AutoMapper;

namespace CheerChampionship.API.Championship.Mappers
{
    public class ChampionshipMapper : Profile
    {
        public ChampionshipMapper()
        {
            CreateMap<CampeonatoDto, Campeonato>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Data))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Local));
        }
    }
}
