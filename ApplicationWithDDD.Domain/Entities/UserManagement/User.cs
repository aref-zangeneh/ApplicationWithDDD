
using ApplicationWithDDD.Domain.DomainEvents;
using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Domain;

namespace ApplicationWithDDD.Domain.Entities.UserManagement
{
    public class User : AggregateRoot<BaseId>
    {
        private Username _username;
        private Password _passwordHash;
        private Email _email;
        private bool _isConfirmed;
        private LinkedList<UserRole> _userRoles;
        private LinkedList<CourseAttendee> _courseAttendees;

        internal User(BaseId id, Username username, Password passwordHash, Email email, bool isConfirmed)
        {
            Id = id;
            _username = username;
            _passwordHash = passwordHash;
            _email = email;
            _isConfirmed = isConfirmed;
            RaiseDomainEvent(new UserRegisteredEvent(this));
        }

        public User()
        {
            
        }

        #region Domain Event

        #endregion

    }
}
