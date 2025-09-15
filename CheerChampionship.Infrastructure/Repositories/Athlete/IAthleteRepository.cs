using CheerChampionship.Infrastructure.Data.Models;

namespace CheerChampionship.Infrastructure.Repositories.Athlete
{
    public interface IAthleteRepository
    {
        Task AddAsync(AtletaData championships);
    }
}