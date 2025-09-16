using CheerChampionship.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CheerChampionship.Infrastructure;
using CheerChampionship.Infrastructure.Data;

namespace CheerChampionship.Infrastructure.Repositories.Championship
{
    public class ChampionshipRepository : IChampionshipRepository
    {
        private readonly CheerDbContext _context;

        public ChampionshipRepository(CheerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Data.Models.CampeonatoData>> GetAllAsync()
        {
            return await _context.Campeonatos.ToListAsync();
        }

        public async Task<Data.Models.CampeonatoData?> GetByIdAsync(int id)
        {
            return await _context.Campeonatos.FindAsync(id);
        }

        public async Task AddAsync(Data.Models.CampeonatoData championships)
        {
            _context.Campeonatos.Add(championships);
            await _context.SaveChangesAsync();
        }
    }
}