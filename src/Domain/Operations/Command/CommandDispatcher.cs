using System;
using Domain.API.Command;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Operations.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _container;

        public CommandDispatcher(IServiceProvider container)
        {
            _container = container;
        }

        public void Dispatch<TParameter>(TParameter command)
            where TParameter : ICommand
        {
            _container.GetService<ICommandHandler<TParameter>>().Execute(command);
        }
    }
}