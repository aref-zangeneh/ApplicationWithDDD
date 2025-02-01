using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseCatalogNotFoundException : CourseManagementException
    {
        public CourseCatalogNotFoundException() : base("Course Catalog not found.")
        {
        }
    }
}
