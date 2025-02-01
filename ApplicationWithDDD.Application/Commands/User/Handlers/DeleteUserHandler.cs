

using ApplicationWithDDD.Application.Exceptions;
using ApplicationWithDDD.Domain.Repositories.UserManagement;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.User.Handlers
{
    public class DeleteUserHandler : ICommandHandler<DeleteUser>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(DeleteUser command)
        {
            var user = await _userRepository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            await _userRepository.DeleteAsync(user.Id);
        }
    }
}
