using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Factories.UserManagement
{
    public class RoleFactory : IRoleFactory
    {
        public Role Create(BaseId id, RoleName roleName)
        {
            return new Role(id, roleName);
        }
    }
}
