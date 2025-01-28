

using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidBiographyLengthException : CourseManagementException
    {
        public InvalidBiographyLengthException() : base("Biography can not be exceed 500 characters")
        {
        }
    }
}
