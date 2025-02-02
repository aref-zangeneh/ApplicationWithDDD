using ApplicationWithDDD.Application.Services;
using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Services
{
    public class UserReadModelService : IUserReadModelService
    {
        private readonly ReadDBContext _dbContext;

        public UserReadModelService(ReadDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> IsUserExistsByEmail(Email email)
        {
            return await _dbContext.Users.AnyAsync(u => u.Email == email);
        }
    }
}
