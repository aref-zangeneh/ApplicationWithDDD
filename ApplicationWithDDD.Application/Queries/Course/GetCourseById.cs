using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;


namespace ApplicationWithDDD.Application.Queries.Course
{
    public class GetCourseById : IQuery<CourseDto>
    {
        public Guid CourseId { get; set; }


    }
}
