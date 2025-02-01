

using ApplicationWithDDD.Domain.Factories.UserManagement;
using ApplicationWithDDD.Domain.Repositories.UserManagement;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.User.Handlers
{
    public class AddUserHandler : ICommandHandler<AddUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public AddUserHandler(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task HandleAsync(AddUser command)
        {
            var user = _userFactory.Create(command.id, command.username, command.passwordHash, command.email, command.isConfirmed);

            await _userRepository.AddAsync(user);
        }
    }
}
