using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<List<User>> GetAllAsync()
        {
            return _context.Users.ToListAsync();
        }

        public Task<User> GetByIdAsync(int id)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public Task<User> GetUserByEmailAsync(string email)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
        public Task<User> GetUserByUsernameAsync(string username)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public Task AddAsync(User entity)
        {
            _context.Users.Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            return _context.SaveChangesAsync();
        }

        public Task DeleteAsync(User entity)
        {
            _context.Users.Remove(entity);
            return _context.SaveChangesAsync();
        }
    }
}
