using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;


namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Title
    {
        public string Value { get; }
        private int _validLength = 50;

        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) 
                throw new TitleNullOrEmptyException();

            if (value.Length > _validLength)
                throw new InvalidTitleLengthException(_validLength);

            Value = value;
        }

        // return the value
        public static implicit operator string(Title title) => title.Value;
        // for being new and pass
        public static implicit operator Title(string title) => new (title);
    }
}
