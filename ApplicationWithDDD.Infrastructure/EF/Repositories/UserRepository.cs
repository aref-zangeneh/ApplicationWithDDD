
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.Repositories.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WriteDBContext _dbContext;

        public UserRepository(WriteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<User>> GetAllAsync()
        {
            return await _dbContext.Users
                .Include("_userRoles")
                .ToListAsync();
        }

        public async Task<User> GetAsync(BaseId id)
        {
            return await _dbContext
                .Users
                .SingleOrDefaultAsync(u =>u.Id == id);
        }

        public async Task AddAsync(User entity)
        {
            await _dbContext.Users.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User entity)
        {
            _dbContext.Users
                .Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(User entity)
        {
            _dbContext.Users
                .Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
