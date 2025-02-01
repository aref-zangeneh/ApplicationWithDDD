using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;


namespace ApplicationWithDDD.Application.Queries.Course
{
    public class GetCoursesList : IQuery<IEnumerable<CourseDto>>
    {
    }
}
