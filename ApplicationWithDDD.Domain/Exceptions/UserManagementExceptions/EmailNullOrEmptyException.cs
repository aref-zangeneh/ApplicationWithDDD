using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class EmailNullOrEmptyException : UserManagementException
    {
        public EmailNullOrEmptyException() : base("Email can not be null or empty...")
        {
        }
    }
}
