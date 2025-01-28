

using ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record RoleName
    {
        public string Value { get; }

        public RoleName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new RoleNameNullOrEmptyException();

            Value = value;
        }

        // return the value
        public static implicit operator string(RoleName roleName) => roleName.Value;
        // for being new and pass
        public static implicit operator RoleName(string roleName) => new(roleName);
    }
}
