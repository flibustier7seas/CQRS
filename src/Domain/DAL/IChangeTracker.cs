namespace Domain.DAL
{
    public interface IChangeTracker<TEntity>
        where TEntity : class
    {
        void Add(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
