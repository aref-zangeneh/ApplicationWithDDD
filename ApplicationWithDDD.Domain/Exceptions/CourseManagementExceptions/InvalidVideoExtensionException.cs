using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoExtensionException : CourseManagementException
    {
        public InvalidVideoExtensionException() : base("just mp4 is a valid extension for video...")
        {
        }
    }
}
