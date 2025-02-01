using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;


namespace ApplicationWithDDD.Domain.Factories.UserManagement
{
    public interface IUserFactory
    {
        User Create(BaseId id, Username username, Password passwordHash, Email email, bool isConfirmed);
    }
}
