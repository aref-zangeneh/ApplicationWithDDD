

using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Description
    {
        public string Value { get; }
        private int _validLength = 500;
        public Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DescriptionNullOrEmptyException();

            if (value.Length > _validLength)
                throw new InvalidDescriptionLengthException(_validLength);

            Value = value;
        }
        // return the value
        public static implicit operator string(Description description) => description.Value;
        // for being new and pass
        public static implicit operator Description(string description) => new(description);

    }
}
