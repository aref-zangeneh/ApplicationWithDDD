using ApplicationWithDDD.Application.Services;
using ApplicationWithDDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Services
{
    public class CourseReadModelService : ICourseReadModelService
    {
        private readonly ReadDBContext _dbContext;

        public CourseReadModelService(ReadDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> IsCourseExistsByName(string courseName)
        {
            return await _dbContext.Courses.AnyAsync(c => c.Title.Contains(courseName));

        }
    }
}
