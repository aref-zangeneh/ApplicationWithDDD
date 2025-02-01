using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.User.Handlers
{
    public class GetUsersListHandler : IQueryHandler<GetUsersList, IEnumerable<UserDto>>
    {
        public Task<IEnumerable<UserDto>> HandleAsync(GetUsersList query)
        {
            throw new NotImplementedException();
        }
    }
}
