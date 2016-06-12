using System.Linq;
using Domain.API.Command;
using Domain.DAL;
using Domain.Entities;

namespace Domain.Operations.Command.ProductTypeCommand
{
    public class CreateProductTypeCommandHandler : ICommandHandler<CreateProductTypeCommand>
    {
        private readonly IRepository<ProductType> _productTypeRepository;
        private readonly IChangeTracker<ProductType> _changeTracker;


        public CreateProductTypeCommandHandler(
            IRepository<ProductType> productTypeRepository,
            IChangeTracker<ProductType> changeTracker)
        {
            _productTypeRepository = productTypeRepository;
            _changeTracker = changeTracker;
        }

        public void Execute(CreateProductTypeCommand command)
        {
            var productType = new ProductType()
            {
                Name = command.Name,
                Attributes = command.Attributes.ToList()
            };

            _productTypeRepository.Add(productType);
            _productTypeRepository.Save();

            _changeTracker.Add(productType);
        }
    }
}

