

namespace ApplicationWithDDD.Domain.Entities.UserManagement
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
