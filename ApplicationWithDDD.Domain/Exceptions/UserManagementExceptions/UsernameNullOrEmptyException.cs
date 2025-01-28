using ApplicationWithDDD.Shared.Abstraction.Exceptions;

namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class UsernameNullOrEmptyException : UserManagementException
    {
        public UsernameNullOrEmptyException() : base("Username can not be null or empty...")
        {
        }
    }
}
