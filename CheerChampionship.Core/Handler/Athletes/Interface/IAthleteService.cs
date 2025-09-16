using CheerChampionship.Core.Handler.Athletes.Models;

namespace CheerChampionship.Core.Handler.Athletes.Interface
{
    public interface IAthleteService
    {
        Task AddAtletaAsync(Atleta atleta);
        Task EditarAtletaAsync(Atleta atleta);
        Task DeletaAtletaAsync(Atleta atleta);
        Task<Atleta> GetAtletaByIdAsync(int id);
        Task<IEnumerable<Atleta>> GetAllAtletaAsync();
    }
}