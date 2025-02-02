using ApplicationWithDDD.Infrastructure.EF.Models.UserManagement;

namespace ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement
{
    public class CourseAttendeeReadModel : BaseReadModel
    {
        public Guid UserId { get; set; }
        public UserReadModel User { get; set; }
        public Guid CourseId { get; set; }
        public CourseReadModel Course { get; set; }

    }
}
