using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.Course
{
    public record DeleteCourse(BaseId Id) : ICommand;
    
}
