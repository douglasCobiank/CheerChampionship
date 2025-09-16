using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes.Interface
{
    public interface IAthleteHandler
    {
        Task CadastraAthleteHandler(Atleta atleta);
        Task EditarAthletaHandler(Atleta atleta);
        Task DeletaAthletaHandler(Atleta atleta);
        Task<Atleta> GetAthletaByIdHandler(int id);
        Task<IEnumerable<Atleta>> GetAllAthletaHandler();
    }
}