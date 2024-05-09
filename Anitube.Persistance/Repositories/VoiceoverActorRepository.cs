using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class VoiceoverActorRepository : IVoiceoverActorRepository
    {
        private readonly AppDbContext _appDbContext;

        public VoiceoverActorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<VoiceoverActor>> GetAllAsync()
        {
            return await _appDbContext.VoiceoverActors.ToListAsync();
        }

        public async Task<VoiceoverActor> GetByIdAsync(int id)
        {
            return await _appDbContext.VoiceoverActors.FirstOrDefaultAsync(a => a.Id == id);
        }

        public Task AddAsync(VoiceoverActor entity)
        {
            _appDbContext.VoiceoverActors.Add(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task UpdateAsync(VoiceoverActor entity)
        {
            _appDbContext.VoiceoverActors.Update(entity);
            return _appDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(VoiceoverActor entity)
        {
            _appDbContext.VoiceoverActors.Remove(entity);
            return _appDbContext.SaveChangesAsync();
        }
    }
}
