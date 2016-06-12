using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.DAL;
using MongoDB.Driver;

namespace mongo
{
    public class MongoRepository<TEntity> : IRepository<TEntity>, IFinder<TEntity>, IChangeTracker<TEntity>
        where TEntity : class
    {
        private readonly IMongoCollection<TEntity> _collection;

        public MongoRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<TEntity>(typeof (TEntity).Name);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _collection.Find(FilterDefinition<TEntity>.Empty).ToList();
        }

        public IEnumerable<TEntity> FindMany(Expression<Func<TEntity, bool>> predicate)
        {
            return _collection.Find(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            _collection.InsertOne(entity);
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

        }
    }
}
