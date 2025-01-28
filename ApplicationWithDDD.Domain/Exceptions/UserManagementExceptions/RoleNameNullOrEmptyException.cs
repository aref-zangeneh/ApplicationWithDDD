using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class RoleNameNullOrEmptyException : UserManagementException
    {
        public RoleNameNullOrEmptyException() : base("Role name must not be null or empty...")
        {
        }
    }
}
