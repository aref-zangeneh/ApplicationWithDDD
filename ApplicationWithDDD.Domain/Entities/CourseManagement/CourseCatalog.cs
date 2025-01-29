

using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class CourseCatalog : BaseEntity
    {
        private Title _title;
        private Description _description;
        private BaseId _courseId;
        private LinkedList<Course> _lessons;

        internal CourseCatalog(BaseId id, Title title, Description description, BaseId courseId) : base(id)
        {
            _title = title;
            _description = description;
            _courseId = courseId;
        }

        public CourseCatalog(BaseId id) : base(id)
        {
            
        }

    }
}
