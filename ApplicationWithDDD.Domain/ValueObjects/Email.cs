

using ApplicationWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new EmailNullOrEmptyException();

            var emailAddress = new System.Net.Mail.MailAddress(value);
            if (emailAddress.Address != value)
                throw new InvalidEmailException();




            Value = value;
        }

        // return the value
        public static implicit operator string(Email email) => email.Value;
        // for being new and pass
        public static implicit operator Email(string email) => new(email);
    }
}
