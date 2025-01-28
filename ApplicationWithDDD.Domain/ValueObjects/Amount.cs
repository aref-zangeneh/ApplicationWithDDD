

using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;
using ApplicationWithDDD.Domain.Exceptions.PaymentManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Amount
    {
        public decimal Value{ get; set; }
        public Amount(decimal value)
        {
            if (value < 0)
                throw new InvalidAmountException();

            Value = value;
        }
        // return the value
        public static implicit operator decimal(Amount amount) => amount.Value;
        // for being new and pass
        public static implicit operator Amount(string amount) => new(amount);
    }
}
