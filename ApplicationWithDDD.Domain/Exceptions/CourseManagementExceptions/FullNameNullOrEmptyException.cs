using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class FullNameNullOrEmptyException : CourseManagementException
    {
        public FullNameNullOrEmptyException() : base("FullName can not be null or empty...")
        {
        }
    }
}
