using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class DescriptionNullOrEmptyException : CourseManagementException
    {
        public DescriptionNullOrEmptyException() : base("Description can not be null / empty so far...")
        {
        }
    }
}
