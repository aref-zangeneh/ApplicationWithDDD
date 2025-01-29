
using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Domain.Entities.UserManagement
{
    public class User : BaseEntity
    {
        private Username _username;
        private Password _passwordHash;
        private Email _email;
        private bool _isConfirmed;
        private LinkedList<UserRole> _userRoles;

        internal User(BaseId id, Username username, Password passwordHash, Email email, bool isConfirmed) : base(id)
        {
            _username = username;
            _passwordHash = passwordHash;
            _email = email;
            _isConfirmed = isConfirmed;
        }

        public User(BaseId id) : base(id)
        {
            
        }

    }
}
