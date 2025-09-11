using CheerChampionship.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CheerChampionship.Infrastructure;

namespace CheerChampionship.Infrastructure.Repositories.Campeonato
{
    public class CampeonatoRepository : ICampeonatoRepository
    {
        private readonly CheerDbContext _context;

        public CampeonatoRepository(CheerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Data.Models.Campeonato>> GetAllAsync()
        {
            return await _context.Campeonatos.ToListAsync();
        }

        public async Task<Data.Models.Campeonato?> GetByIdAsync(int id)
        {
            return await _context.Campeonatos.FindAsync(id);
        }

        public async Task AddAsync(Data.Models.Campeonato championships)
        {
            _context.Campeonatos.Add(championships);
            await _context.SaveChangesAsync();
        }
    }
}