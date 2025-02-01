

using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class InvalidInstructorExperienceException : CourseManagementException
    {
        public InvalidInstructorExperienceException() : base("Experience must not be less than 3 years.")
        {
        }
    }
}
