using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Data;

namespace CheerChampionship.Infrastructure.Repositories.Championship
{
    public class ChampionshipRepository (CheerDbContext context) : Repository<CampeonatoData>(context) , IChampionshipRepository
    {
    }
}