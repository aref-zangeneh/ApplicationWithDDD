using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public class CourseCatalogFactory : ICourseCatalogFactory
    {
        public CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId)
        {
            return new CourseCatalog(id, title, description, courseId);
        }
    }
}
