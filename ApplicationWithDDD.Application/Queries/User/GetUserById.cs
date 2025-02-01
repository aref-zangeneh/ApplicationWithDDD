using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.User
{
    public class GetUserById : IQuery<UserDto>
    {
    }
}
