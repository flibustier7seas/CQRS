using System.Collections.Generic;
using Domain.API.Query;

namespace Domain.Operations.Query.ProductTypeQuery
{
    public class ProductTypeIdsQuery : IQuery
    {
        public IEnumerable<long> Ids { get; set; }
    }
}