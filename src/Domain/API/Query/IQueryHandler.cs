namespace Domain.API.Query
{
    /// <summary>
    /// ���������� �������
    /// </summary>
    public interface IQueryHandler<in TParameter, out TResult>
        where TParameter : IQuery   
        where TResult : IQueryRersult
    {
        TResult Execute(TParameter query);
    }
}