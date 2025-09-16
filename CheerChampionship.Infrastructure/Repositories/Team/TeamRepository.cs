using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Data;

namespace CheerChampionship.Infrastructure.Repositories.Team
{
    public class TeamRepository (CheerDbContext context) : Repository<EquipeData>(context), ITeamRepository
    {
    }
}