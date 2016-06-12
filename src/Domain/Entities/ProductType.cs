using System.Collections.Generic;

namespace Domain.Entities
{
    public class ProductType
    {
        public long Id { get; set; }
        public string Name { get; set; }

        //NOTE: virtual for EF
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
