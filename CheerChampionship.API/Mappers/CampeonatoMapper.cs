using CheerChampionship.Core;
using CheerChampionship.Core.Handler.Championships.Models;
using CheerChampionship.API.Models;
using AutoMapper;

namespace CheerChampionship.API.Mappers
{
    public class CampeonatoMapper : Profile
    {
        public CampeonatoMapper()
        {
            CreateMap<Campeonato, Championship>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Data))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Local));
        }
    }
}
