using Domain.Entities;

using Microsoft.Data.Entity;

namespace EF
{
    public class EfContext: DbContext
    {
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Attribute> Attributes { get; set; }

        public new DbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Attribute>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Attribute>()
                .Property(b => b.Type)
                .IsRequired();
        }
    }
}
