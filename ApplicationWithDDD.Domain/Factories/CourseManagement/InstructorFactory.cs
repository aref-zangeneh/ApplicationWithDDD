

using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.CourseManagement
{
    public class InstructorFactory : IInstructorFactory
    {
        public Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int exprience, double rating)
        {
            if (exprience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }

            if (rating < 0)
            {
                throw new InvalidInstructorRatingException();
            }

            return new Instructor(id, fullName, biography, exprience, rating);
        }

        public Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int exprience)
        {
            if(exprience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }
            return new Instructor(id, fullName, biography, exprience);
        }

        public Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography)
        {
            

            return new Instructor(id, fullName, biography);
        }
    }
}
