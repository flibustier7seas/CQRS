using System.Linq;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.DAL;

namespace EF
{
    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbSet<TEntity> _entities;
        private readonly EfContext _context;

        public EfRepository(EfContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> FindMany(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).ToArray();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToArray();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);            
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}