

using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.Course.Handlers
{
    public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDto>
    {
        public Task<CourseDto> HandleAsync(GetCourseById query)
        {
            throw new NotImplementedException();
        }
    }
}
