

using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Application.Exceptions
{
    public class CourseNotFoundException : CourseManagementException
    {
        public CourseNotFoundException() : base("Course Not Found.")
        {
        }
    }
}
