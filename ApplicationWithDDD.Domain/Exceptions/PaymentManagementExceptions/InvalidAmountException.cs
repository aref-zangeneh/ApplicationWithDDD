using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.PaymentManagementExceptions
{
    internal class InvalidAmountException : PaymentManagementException
    {
        public InvalidAmountException() : base("Amount can not be negative...")
        {
            
        }
    }
}
