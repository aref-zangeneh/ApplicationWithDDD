
using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.User.Handlers
{
    public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDto>
    {
        public Task<UserDto> HandleAsync(GetUserById query)
        {
            throw new NotImplementedException();
        }
    }
}
