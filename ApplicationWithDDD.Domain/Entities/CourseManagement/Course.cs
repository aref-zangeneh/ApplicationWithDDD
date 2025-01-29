using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Domain;

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class Course : AggregateRoot<BaseId>
    {
        // fields, attributes | All fields are encapsulated
        private Title _title;
        private Description _description;
        private bool _isFree;
        private Price _price;
        private BaseId _instructorId;
        private LinkedList<CourseAttendee> _courseAttendees;
        private LinkedList<CourseCatalog> _courseCatalogs;

        internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId, LinkedList<CourseAttendee> courseAttendees, LinkedList<CourseCatalog> courseCatalogs)
        {
            Id = id;
            _title = title;
            _description = description;
            _isFree = isFree;
            _price = price;
            _instructorId = instructorId;
            _courseAttendees = courseAttendees;
            _courseCatalogs = courseCatalogs;
        }

        public Course()
        {

        }
    }
}
