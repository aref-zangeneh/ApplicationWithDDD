using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class InvalidInstructorRatingException : CourseManagementException
    {
        public InvalidInstructorRatingException() : base("Instructor rating must not be less than 0 or negative")
        {
        }
    }
}
