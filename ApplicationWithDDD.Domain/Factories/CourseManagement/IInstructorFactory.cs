using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public interface IInstructorFactory 
    {
        Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography);
        Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int exprience);
        Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int exprience, double rating);
    }
}
