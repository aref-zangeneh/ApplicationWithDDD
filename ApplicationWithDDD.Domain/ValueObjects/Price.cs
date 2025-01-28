using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Price
    {
        public decimal Value { get; }

        public Price(decimal value)
        {
            if (value < 0)
                throw new InvalidPriceException();

            Value = value;
        }
        // return the value
        public static implicit operator decimal(Price price) => price.Value;
        // for being new and pass
        public static implicit operator Price(string price) => new(price);
    }
}
