using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.User
{
    public record DeleteUser(BaseId id) : ICommand;
}
