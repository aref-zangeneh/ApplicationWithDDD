using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class PasswordNullOrEmptyException : UserManagementException
    {
        public PasswordNullOrEmptyException() : base("Password must not be empty or null ...")
        {
        }
    }
}
