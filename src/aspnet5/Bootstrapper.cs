using Domain.API.Command;
using Domain.API.Query;
using Domain.Operations.Command;
using Domain.Operations.Query;
using EF;
using Microsoft.Extensions.DependencyInjection;
using Domain.DAL;
using Domain.Operations.Command.ProductTypeCommand;
using Domain.Operations.Query.ProductTypeQuery;
using mongo;
using MongoDB.Driver;

namespace aspnet5
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            
            services.AddScoped(typeof(IFinder<>), typeof(MongoRepository<>));
            services.AddScoped(typeof(IChangeTracker<>), typeof(MongoRepository<>));

            services.AddScoped<IQueryHandler<AllProductTypesQuery, ProductTypesQueryResult>, GetAllProductsQueryHandler>();
            services.AddScoped<IQueryHandler<ProductTypeIdsQuery, ProductTypesQueryResult>, GetProductTypesByIdsQueryHandler>();

            services.AddScoped<ICommandHandler<CreateProductTypeCommand>, CreateProductTypeCommandHandler>();

            return services;
        }

        public static IServiceCollection AddMongoDatabase(
            this IServiceCollection services,
            string connectionString,
            string databaseName)
        {
            services.AddSingleton(typeof(IMongoDatabase),
                x => new MongoClient(connectionString).GetDatabase(databaseName));

            return services;
        }
    }
}
