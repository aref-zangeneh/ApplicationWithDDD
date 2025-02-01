using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Shared.Abstraction.Domain;


namespace ApplicationWithDDD.Domain.DomainEvents
{
    public record NewCourseCreatedEvent(Course course) : IDomainEvent;


}
