using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseAttendeeAlreadyExistsException : CourseManagementException
    {
        public CourseAttendeeAlreadyExistsException() : base("Course attendee is already exists.")
        {

        }
    }
}
