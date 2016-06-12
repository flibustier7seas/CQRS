using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.DAL
{
    public interface IFinder<TEntity>
            where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindMany(Expression<Func<TEntity, bool>> predicate);
    }
}
