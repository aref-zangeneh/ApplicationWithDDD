using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public class CourseAttendeeFactory : ICourseAttendeeFactory
    {
        public CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId)
        {
            return new CourseAttendee(id, courseId, userId);
        }
    }
}
