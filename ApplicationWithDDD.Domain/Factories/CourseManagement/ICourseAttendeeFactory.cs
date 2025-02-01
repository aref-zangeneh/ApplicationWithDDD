using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseAttendeeFactory
    {
        CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId);
    }
}
