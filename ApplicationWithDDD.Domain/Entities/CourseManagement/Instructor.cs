
using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class Instructor : BaseEntity
    {
        private FullName _fullName;
        private Biography _biography;
        private int _exprience;
        private double _rating;
        private LinkedList<Course> _courses;
        internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _exprience = 3;
            _rating = 0;
        }

        internal Instructor(BaseId id, FullName fullName, Biography biography, int exprience) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _exprience = exprience;
            _rating = 0;
        }

        internal Instructor(BaseId id, FullName fullName, Biography biography, int exprience, double rating) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _exprience = exprience;
            _rating = rating;
        }


        public Instructor(BaseId id) : base(id)
        {
            
        }

    }
}
