using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Repositories.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly WriteDBContext _dbContext;

        public CourseRepository(WriteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<Course>> GetAllAsync()
        {
            return await _dbContext.Courses
                .Include("_courseAttendees")
                .ToListAsync();
        }

        public async Task<Course> GetAsync(BaseId id)
        {
            return await _dbContext
                .Courses
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task AddAsync(Course entity)
        {
            await _dbContext.Courses.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course entity)
        {
            _dbContext.Courses
                .Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Course entity)
        {
            _dbContext.Courses
                .Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
