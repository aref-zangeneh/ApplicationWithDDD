using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseCatalogAlreadyExistsException : CourseManagementException
    {
        public CourseCatalogAlreadyExistsException() : base("Course catalog is already exists.")
        {
        }
    }
}
