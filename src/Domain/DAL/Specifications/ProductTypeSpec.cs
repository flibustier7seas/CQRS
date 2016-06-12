using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.DAL.Specifications
{
    public static class ProductTypeSpec
    {
        public static Expression<Func<ProductType, bool>> ById(long id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<ProductType, bool>> ByIds(IEnumerable<long> ids)
        {
            return x => ids.Contains(x.Id);
        }
    }
}
