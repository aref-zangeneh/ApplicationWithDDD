
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetAsync(BaseId id);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(BaseId id);

    }
}
