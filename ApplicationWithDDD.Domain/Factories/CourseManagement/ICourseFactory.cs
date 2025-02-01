using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseFactory
    {
        Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId);
    }
}
