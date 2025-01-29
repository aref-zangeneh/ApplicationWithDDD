

using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class Lesson : BaseEntity
    {
        private Title _title;
        private VideoUrl _videoUrl;
        private BaseId _courseCatalogId;

        internal Lesson(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId) : base(id)
        {
            _title = title;
            _videoUrl = videoUrl;
            _courseCatalogId = courseCatalogId;
        }

        public Lesson(BaseId id) : base(id)
        {
            
        }

    }
}
