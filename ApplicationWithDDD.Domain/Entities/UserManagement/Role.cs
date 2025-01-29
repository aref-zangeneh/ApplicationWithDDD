

using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.UserManagement
{
    public class Role : BaseEntity
    {
        private RoleName _roleName;
        private LinkedList<Role> _roles;

        internal Role(BaseId id, RoleName roleName) : base(id)
        {
            _roleName = roleName;
        }

        public Role(BaseId id) : base(id)
        {
            
        }
    }
}
