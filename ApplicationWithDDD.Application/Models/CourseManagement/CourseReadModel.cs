

using ApplicationWithDDD.Application.Models.PaymentManagement;

namespace ApplicationWithDDD.Application.Models.CourseManagement
{
    public class CourseReadModel : BaseReadModel
    {
        public string Title { get; set; }
        public string Desctription { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public Guid InstructorId { get; set; }
        public InstructorReadModel Instructor { get; set; }
        public IReadOnlyList<CourseAttendeeReadModel> CourseAttendees { get; set; }
        public IReadOnlyList<CourseCatalogReadModel> CourseCatalogs { get; set; }
        public IReadOnlyList<InvoiceReadModel> Invoices{ get; set; }


    }
}
