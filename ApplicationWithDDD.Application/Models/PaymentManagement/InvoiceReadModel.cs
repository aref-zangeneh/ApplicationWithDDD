using ApplicationWithDDD.Application.Models;
using ApplicationWithDDD.Application.Models.CourseManagement;
using ApplicationWithDDD.Application.Models.UserManagement;

namespace ApplicationWithDDD.Application.Models.PaymentManagement
{
    public class InvoiceReadModel : BaseReadModel
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public UserReadModel User { get; set; }
        public Guid CourseId { get; set; }
        public CourseReadModel Course { get; set; }
    }
}
