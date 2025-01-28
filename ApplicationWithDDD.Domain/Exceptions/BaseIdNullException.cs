using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions
{
    internal class BaseIdNullException : CourseManagementException
    {
        public BaseIdNullException() : base("Id can not be null / empty")
        {
        }
    }
}
