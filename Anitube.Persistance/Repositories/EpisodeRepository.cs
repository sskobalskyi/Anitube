using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EpisodeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task AddAsync(Episode entity)
        {
            _appDbContext.Episodes.Add(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Episode entity)
        {
            _appDbContext.Episodes.Remove(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task<List<Episode>> GetAllAsync()
        {
            return _appDbContext.Episodes.ToListAsync();
        }

        public Task<Episode> GetByIdAsync(int id)
        {
            return _appDbContext.Episodes.FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task UpdateAsync(Episode entity)
        {
            _appDbContext.Episodes.Update(entity);
            return _appDbContext.SaveChangesAsync();
        }
    }
}
