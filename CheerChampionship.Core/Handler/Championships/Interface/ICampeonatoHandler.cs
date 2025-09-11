using CheerChampionship.Core.Handler.Championships.Models;
using System.Threading.Tasks;

namespace CheerChampionship.Core.Handler.Championships.Interface
{
    public interface ICampeonatoHandler
    {
        Task CadastraCampeonatoHandler(Championship campeonato);
        void EditaCampeonatoHandler(Championship campeonato);
        void BuscaCampeonatoHandler(string nome, string cidade);
    }
}