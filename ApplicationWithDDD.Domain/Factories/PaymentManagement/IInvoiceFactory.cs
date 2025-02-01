using ApplicationWithDDD.Domain.Entities.PaymentManagement;
using ApplicationWithDDD.Domain.ValueObjects;


namespace ApplicationWithDDD.Domain.Factories.PaymentManagement
{
    public interface IInvoiceFactory
    {
        Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId);
    }
}
