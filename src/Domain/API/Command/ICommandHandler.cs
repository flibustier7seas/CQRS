namespace Domain.API.Command
{
    /// <summary>
    /// Обработчик команды
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandHandler<in T>
        where T : ICommand
    {
        void Execute(T command);
    }
}