using ApplicationWithDDD.Domain.DomainEvents;
using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;
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
            RaiseDomainEvent(new NewCourseCreatedEvent(this));
        }

        public Course()
        {

        }

        #region Course Attendee Domain Activities
        // Domain Activities
        public void AddCourseAttendee(CourseAttendee courseAttendee)
        {
            var attendeeExists = _courseAttendees.Any(a => a.Id == courseAttendee.Id);
            if (attendeeExists)
            {
                throw new CourseAttendeeAlreadyExistsException();
            }
            _courseAttendees.AddLast(courseAttendee);
            // Raise Event
            RaiseDomainEvent(new CourseAttendeeAddedEvent(this, courseAttendee));
        }

        public void RemoveCourseAttendee(BaseId id)
        {
            var attendee = GetAttendee(id);

            _courseAttendees.Remove(attendee);
        }
        #endregion

        // this is not a activity because its just simple get method
        private CourseAttendee GetAttendee(BaseId id)
        {
            var attendee = _courseAttendees.SingleOrDefault(a => a.Id == id);
            if (attendee == null)
            {
                throw new CourseAttendeeNotFoundException();
            }
            return attendee;
        }

        #region Course Catalog Domain Activities
        // Domain Activities
        public void AddCourseCatalog(CourseCatalog courseCatalog)
        {
            var courseExists = _courseCatalogs.Any(a => a.Id == courseCatalog.Id);
            if (courseExists)
            {
                throw new CourseCatalogAlreadyExistsException();
            }
            _courseCatalogs.AddLast(courseCatalog);
        }

        public void RemoveCourseCatalog(BaseId id)
        {
            var course = GetCourseCatalog(id);

            _courseCatalogs.Remove(course);
        }
        #endregion

        // this is not a activity because its just simple get method
        private CourseCatalog GetCourseCatalog(BaseId id)
        {
            var course = _courseCatalogs.SingleOrDefault(a => a.Id == id);
            if (course == null)
            {
                throw new CourseCatalogNotFoundException();
            }
            return course;
        }



        #region Domain Events

        #endregion
    }

}
