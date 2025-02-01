using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseCatalogFactory
    {
        CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
    }
}
