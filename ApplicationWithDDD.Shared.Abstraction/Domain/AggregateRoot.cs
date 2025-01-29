

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


    }
}
