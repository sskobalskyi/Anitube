using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext _appDbContext;

        public GenreRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public Task<List<Genre>> GetAllAsync()
        {
            return _appDbContext.Genres.ToListAsync();
        }

        public Task<Genre> GetByIdAsync(int id)
        {
            return _appDbContext.Genres.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task AddAsync(Genre entity)
        {
            _appDbContext.Genres.Add(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Genre entity)
        {
            _appDbContext.Genres.Remove(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task UpdateAsync(Genre entity)
        {
            _appDbContext.Genres.Update(entity);
            return _appDbContext.SaveChangesAsync();
        }
    }
}
