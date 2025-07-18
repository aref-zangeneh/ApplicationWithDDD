﻿

namespace ApplicationWithDDD.Shared.Abstraction.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
    {
        Task HandleAsync(TCommand command);
    }
}
