using AutoMapper;
using CheerChampionship.API.AthletesModels;
using CheerChampionship.API.AthletesModels.Models;
using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.API.Athletes.Mappers
{
    public class AthleteMapper: Profile
    {
        public AthleteMapper()
        {
            // Mapeamento principal
            CreateMap<AtletaDto, Atleta>().ReverseMap();

            // Mapeamento das propriedades complexas
            CreateMap<DocumentoDto, Documento>().ReverseMap();
        }
    }
}