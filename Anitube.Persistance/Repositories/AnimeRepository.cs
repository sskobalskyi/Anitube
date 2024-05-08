using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly AppDbContext _context;

        public AnimeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Anime>> GetAllAsync()
        {
            return _context.Animes.ToListAsync();
        }

        public Task<Anime> GetByIdAsync(int id)
        {
            return _context.Animes.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Anime> GetEnrichedAsync(int id)
        {
            return await _context.Animes
                .Include(a => a.Episodes)
                .Include(a => a.AnimeGenres)
                .ThenInclude(ag => ag.Category)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public Task AddAsync(Anime entity)
        {
            _context.Animes.Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Anime entity)
        {
            _context.Animes.Update(entity);
            return _context.SaveChangesAsync();
        }

        public Task AddGenreAsync(AnimeGenre entity)
        {
            _context.AnimeGenres.Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Anime entity)
        {
            _context.Animes.Remove(entity);
            return _context.SaveChangesAsync();
        }
    }
}