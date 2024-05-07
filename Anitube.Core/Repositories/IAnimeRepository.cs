using Anitube.Core.Entities;

namespace Anitube.Core.Repositories
{
    public interface IAnimeRepository : IRepository<Anime>
    {
        Task<Anime> GetEnrichedAsync(int id);
    }
}
