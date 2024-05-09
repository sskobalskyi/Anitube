using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class VoiceoverStudioRepository : IVoiceoverStudioRepository
    {
        private readonly AppDbContext _context;

        public VoiceoverStudioRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<List<VoiceoverStudio>> GetAllAsync()
        {
            return _context.VoiceoverStudios.ToListAsync();
        }

        public Task<VoiceoverStudio> GetByIdAsync(int id)
        {
            return _context.VoiceoverStudios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task AddAsync(VoiceoverStudio entity)
        {
            _context.VoiceoverStudios.Add(entity);
            return _context.SaveChangesAsync();
        }
        public Task UpdateAsync(VoiceoverStudio entity)
        {
            _context.VoiceoverStudios.Update(entity);
            return _context.SaveChangesAsync();
        }

        public Task DeleteAsync(VoiceoverStudio entity)
        {
            _context.VoiceoverStudios.Remove(entity);
            return _context.SaveChangesAsync();
        }
    }
}
