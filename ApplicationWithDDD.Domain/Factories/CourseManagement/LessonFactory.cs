using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;


namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public class LessonFactory : ILessonFactory
    {
        public Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId)
        {
            return new Lesson(id, title, videoUrl, courseCatalogId);
        }
    }
}
