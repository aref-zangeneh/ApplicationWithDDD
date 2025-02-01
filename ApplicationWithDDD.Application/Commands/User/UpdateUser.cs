using ApplicationWithDDD.Domain.ValueObjects;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.User
{
    public record UpdateUser(BaseId id, Username username, Password passwordHash, Email email, bool isConfirmed) : ICommand;
}
