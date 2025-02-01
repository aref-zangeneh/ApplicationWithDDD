using ApplicationWithDDD.Domain.Entities.PaymentManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.PaymentManagement
{
    public class InvoiceFactory : IInvoiceFactory
    {
        public Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId)
        {
            return new Invoice(id, amount, date, userId, courseId);
        }
    }
}
