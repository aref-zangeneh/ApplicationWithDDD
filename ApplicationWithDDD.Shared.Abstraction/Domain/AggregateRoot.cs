

using System.Net;

namespace ApplicationWithDDD.Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        // for controlling concurrency in DB
        public int Version { get; protected set; }

        private bool _isIncremented;
        protected void IncrementVersion()
        {
            if (_isIncremented) return;
            Version++;
            _isIncremented = true;
        }


        // we have more than one aggregate root
        private List<IDomainEvent> _domainEvents = new();
        public IEnumerable<IDomainEvent> DomainEvents => _domainEvents;

        protected void RaiseDomainEvent(IDomainEvent @event)
        {
            // verison should be affected
            if (!_domainEvents.Any() && !_isIncremented)
            {
                Version++;
                _isIncremented = true;
            }
            _domainEvents.Add(@event);
        }
    }
}
