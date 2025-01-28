using ApplicationWithDDD.Shared.Abstraction.Exceptions;
namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidTitleLengthException : CourseManagementException
    {
        public InvalidTitleLengthException(int validLength) : base($"Title must not be more that {validLength} characters...")
        {
        }
    }
}
