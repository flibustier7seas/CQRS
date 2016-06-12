namespace Domain.API.Query
{
    /// <summary>
    /// Обработчик запроса
    /// </summary>
    public interface IQueryHandler<in TParameter, out TResult>
        where TParameter : IQuery   
        where TResult : IQueryRersult
    {
        TResult Execute(TParameter query);
    }
}