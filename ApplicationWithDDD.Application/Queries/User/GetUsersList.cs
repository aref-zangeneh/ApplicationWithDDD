using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.User
{
    public class GetUsersList : IQuery<IEnumerable<UserDto>>
    {
    }
}
