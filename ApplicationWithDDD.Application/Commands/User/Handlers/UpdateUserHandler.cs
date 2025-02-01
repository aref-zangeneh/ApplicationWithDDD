

using ApplicationWithDDD.Application.Exceptions;
using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Factories.UserManagement;
using ApplicationWithDDD.Domain.Repositories.UserManagement;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.User.Handlers
{
    public class UpdateUserHandler : ICommandHandler<UpdateUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public UpdateUserHandler(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task HandleAsync(UpdateUser command)
        {
            var user = await _userRepository.GetAsync(command.id);
            if (user == null) 
            {
                throw new UserNotFoundException();
                    }

            user = _userFactory.Create(user.Id, command.username, command.passwordHash, command.email, command.isConfirmed);
            await _userRepository.UpdateAsync(user);
        }
    }
}
