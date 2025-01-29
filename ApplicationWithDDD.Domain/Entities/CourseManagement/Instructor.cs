
using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class Instructor : BaseEntity
    {
        private FullName _fullName;
        private Biography _biography;
        private LinkedList<Course> _courses;
        internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
        }

        public Instructor(BaseId id) : base(id)
        {
            
        }

    }
}
