

using ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement;
using ApplicationWithDDD.Infrastructure.EF.Models.PaymentManagement;

namespace ApplicationWithDDD.Infrastructure.EF.Models.UserManagement
{
    public class UserReadModel : BaseReadModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public IReadOnlyList<CourseAttendeeReadModel> CourseAttendees { get; set; }
        public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
        public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }


    }
}
