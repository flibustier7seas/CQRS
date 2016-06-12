using System.Collections.Generic;
using Domain.API.Query;
using Domain.Entities;

namespace Domain.Operations.Query.ProductTypeQuery
{
    public class ProductTypesQueryResult : IQueryRersult
    {
        public IEnumerable<ProductType> Items { get; set; }
    }
}