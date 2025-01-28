﻿

namespace ApplicationWithDDD.Domain.Entities.CourseManagement
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public Guid CourseCatalogId { get; set; }
        public CourseCatalog CourseCatalog { get; set; }
    }
}
