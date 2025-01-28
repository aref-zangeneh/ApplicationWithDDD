using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("Title can not be null or empty...")
        {
        }
    }
}
