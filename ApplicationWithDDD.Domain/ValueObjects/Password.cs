using ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions;
using System.Text.RegularExpressions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Password
    {
        public string Value { get; }

        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new PasswordNullOrEmptyException();

            string pattern = "[a-zA-Z0-9!]";
            var regex = new Regex(pattern);
            if (!regex.IsMatch(pattern))
                throw new InvalidPasswordException();

            Value = value;
        }

        // return the value
        public static implicit operator string(Password password) => password.Value;
        // for being new and pass
        public static implicit operator Password(string password) => new(password);
    }
}
