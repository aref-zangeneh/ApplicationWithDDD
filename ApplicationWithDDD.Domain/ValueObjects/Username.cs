using ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Username
    {
        public string Value { get; }

        public Username(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new UsernameNullOrEmptyException();

            Value = value;
        }

        // return the value
        public static implicit operator string(Username username) => username.Value;
        // for being new and pass
        public static implicit operator Username(string username) => new(username);
    }
}
