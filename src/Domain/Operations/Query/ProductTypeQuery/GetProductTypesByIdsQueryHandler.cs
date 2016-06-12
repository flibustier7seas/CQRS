using System.Linq;
using Domain.API.Query;
using Domain.DAL;
using Domain.DAL.Specifications;
using Domain.Entities;

namespace Domain.Operations.Query.ProductTypeQuery
{
    public class GetProductTypesByIdsQueryHandler : IQueryHandler<ProductTypeIdsQuery, ProductTypesQueryResult>
    {
        private readonly IFinder<ProductType> _finder;

        public GetProductTypesByIdsQueryHandler(IFinder<ProductType> finder)
        {
            _finder = finder;
        }

        public ProductTypesQueryResult Execute(ProductTypeIdsQuery category)
        {
            return new ProductTypesQueryResult
            {
                Items = _finder.FindMany(ProductTypeSpec.ByIds(category.Ids)).ToArray()
            };
        }
    }
}
