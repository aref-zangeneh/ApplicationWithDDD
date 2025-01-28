using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidPriceException : CourseManagementException
    {
        public InvalidPriceException() : base("Price can not be negative...")
        {
        }
    }
}
