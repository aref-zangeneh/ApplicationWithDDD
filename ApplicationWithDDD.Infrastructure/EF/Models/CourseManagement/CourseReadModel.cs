

using ApplicationWithDDD.Infrastructure.EF.Models.PaymentManagement;

namespace ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement
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
