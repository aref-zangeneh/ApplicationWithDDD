using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;


namespace ApplicationWithDDD.Domain.Factories.UserManagement
{
    public interface IRoleFactory
    {
        Role Create(BaseId id, RoleName roleName);
    }
}
