using System.Collections.Generic;
using Domain.API.Command;
using Domain.Entities;

namespace Domain.Operations.Command.ProductTypeCommand
{
    public class CreateProductTypeCommand : ICommand
    {
        public string Name { get; set; }
        public IEnumerable<Attribute> Attributes { get; set; }
    }
}