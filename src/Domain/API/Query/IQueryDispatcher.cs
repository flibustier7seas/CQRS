namespace Domain.API.Query
{
    /// <summary>
    /// Получает команду, ищет обработчика
    /// </summary>
    public interface IQueryDispatcher
    {
        TResult Dispatch<TParameter, TResult>(TParameter command) 
            where TParameter : IQuery
            where TResult: IQueryRersult;
    }
}