using CheerChampionship.Infrastructure.Data.Models;
using System.Threading.Tasks;

namespace CheerChampionship.Infrastructure.Repositories.Equipe
{
    public interface IEquipeRepository
    {
        Task AddAsync(Data.Models.Equipe equipe);
    }
}