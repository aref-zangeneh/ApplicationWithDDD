using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.Course
{
    public record AddCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;
}
