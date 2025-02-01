

using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.Course.Handlers
{
    public class GetCoursesListHandler : IQueryHandler<GetCoursesList, IEnumerable<CourseDto>>
    {
        public Task<IEnumerable<CourseDto>> HandleAsync(GetCoursesList query)
        {
            throw new NotImplementedException();
        }
    }
}
