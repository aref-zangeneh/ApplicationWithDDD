using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Shared.Abstraction.Domain;

namespace ApplicationWithDDD.Domain.DomainEvents
{
    public record UserRegisteredEvent(User user) : IDomainEvent;
    
}
