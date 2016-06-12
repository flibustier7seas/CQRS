using System.Linq;
using Domain.API.Query;
using Domain.DAL;
using Domain.Entities;

namespace Domain.Operations.Query.ProductTypeQuery
{
    public class GetAllProductsQueryHandler : IQueryHandler<AllProductTypesQuery, ProductTypesQueryResult>
    {
        private readonly IFinder<ProductType> _finder;

        public GetAllProductsQueryHandler(IFinder<ProductType> finder)
        {
            _finder = finder;
        }

        public ProductTypesQueryResult Execute(AllProductTypesQuery category)
        {
            return new ProductTypesQueryResult
            {
                Items = _finder.GetAll().ToArray()
            };
        }
    }
}
