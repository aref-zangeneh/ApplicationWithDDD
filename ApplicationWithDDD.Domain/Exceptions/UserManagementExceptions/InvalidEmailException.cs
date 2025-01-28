using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidEmailException : UserManagementException
    {
        public InvalidEmailException() : base("Email should be a valid one...")
        {
        }
    }
}
