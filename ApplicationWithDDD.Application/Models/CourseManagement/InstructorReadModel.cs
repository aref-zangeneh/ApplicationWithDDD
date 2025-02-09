

namespace ApplicationWithDDD.Application.Models.CourseManagement
{
    public class InstructorReadModel : BaseReadModel
    {
        public string FullName { get; set; }
        public string Biography { get; set; }
        public int Experience { get; set; }
        public double Rating { get; set; }

        public IReadOnlyList<CourseReadModel> Courses { get; set; }
    }
}
