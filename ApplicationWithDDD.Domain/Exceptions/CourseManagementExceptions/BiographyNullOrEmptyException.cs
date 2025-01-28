
using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class BiographyNullOrEmptyException : CourseManagementException
    {
        public BiographyNullOrEmptyException() : base("Biography can not be empty...")
        {
        }
    }
}
