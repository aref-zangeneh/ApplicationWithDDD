using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class VideoUrlNullOrEmptyException : CourseManagementException
    {
        public VideoUrlNullOrEmptyException() : base("Video URL can not be empty...")
        {
        }
    }
}
