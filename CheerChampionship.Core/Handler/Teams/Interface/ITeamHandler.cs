using CheerChampionship.Core.Handler.Teams.Models;
using System.Threading.Tasks;

namespace CheerChampionship.Core.Handler.Teams.Interface
{
    public interface ITeamHandler
    {
        Task CadastraEquipeHandler(Equipe equipe);
    }
}