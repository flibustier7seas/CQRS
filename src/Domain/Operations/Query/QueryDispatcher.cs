using Domain.API.Query;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Operations.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceProvider _container;

        public QueryDispatcher(IServiceProvider container)
        {
            _container = container;
        }

        public TResult Dispatch<TParameter, TResult>(TParameter command)
            where TParameter : IQuery
            where TResult : IQueryRersult
        {
            return _container.GetService<IQueryHandler<TParameter, TResult>>().Execute(command);
        }
    }
}