using AutoMapper;
using CheerChampionship.Core.Handler.Athletes.Models;
using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Core.Handler.Athletes.Mappers
{
    public class AtletaMapper: Profile
    {
        public AtletaMapper()
        {
            // Mapeamento principal
            CreateMap<Atleta, AtletaData>().ReverseMap();

            // Mapeamento das propriedades complexas
            CreateMap<Documento, DocumentoData>().ReverseMap();
        }
    }
}