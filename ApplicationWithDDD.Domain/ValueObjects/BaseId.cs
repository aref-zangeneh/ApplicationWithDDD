using ApplicationWithDDD.Domain.Exceptions;


namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record BaseId
    {
        // should not be exposed
        public Guid Value { get; }

        public BaseId(Guid value)
        {
            // Validation
            if (value == Guid.Empty)
            {
                throw new BaseIdNullException();
            }
            Value = value;
        }

        // return the value
        public static implicit operator Guid(BaseId id) => id.Value;
        // for being new and pass
        public static implicit operator BaseId(Guid id) => new BaseId(id);
        
    }
}
