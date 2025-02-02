

namespace ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement
{
    public class LessonReadModel : BaseReadModel
    {
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public Guid CatalogId { get; set; }
        public CourseCatalogReadModel CourseCatalog { get; set; }
    }
}
