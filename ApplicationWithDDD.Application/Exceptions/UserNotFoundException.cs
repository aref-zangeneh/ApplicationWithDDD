using ApplicationWithDDD.Shared.Abstraction.Exceptions;


namespace ApplicationWithDDD.Application.Exceptions
{
    public class UserNotFoundException : UserManagementException
    {
        public UserNotFoundException() : base("User Not Found.")
        {
        }
    }
}
