using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.UserManagement
{
    public class UserFactory : IUserFactory
    {
        public User Create(BaseId id, Username username, Password passwordHash, Email email, bool isConfirmed)
        {
            return new User(id, username, passwordHash, email, isConfirmed);
        }
    }
}
