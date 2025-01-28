using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidPasswordException : UserManagementException
    {
        public InvalidPasswordException() : base("Password must be valid and contains a special character")
        {

        }
    }
}
