namespace Domain.API.Command
{
    /// <summary>
    /// Получает команду, ищет обработчика
    /// </summary>
    public interface ICommandDispatcher
    {
        void Dispatch<T>(T command) where T : ICommand;
    }
}