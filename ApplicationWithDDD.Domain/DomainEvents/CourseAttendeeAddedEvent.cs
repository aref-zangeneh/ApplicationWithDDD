using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Shared.Abstraction.Domain;

namespace ApplicationWithDDD.Domain.DomainEvents
{
    public record CourseAttendeeAddedEvent(Course course, CourseAttendee courseAttendee) : IDomainEvent;
    
}
