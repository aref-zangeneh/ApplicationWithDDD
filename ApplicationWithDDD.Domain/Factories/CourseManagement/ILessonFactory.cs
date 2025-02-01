using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public interface ILessonFactory
    {
        Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId);
    }
}
