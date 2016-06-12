using Domain.API.Command;
using Domain.API.Query;
using Domain.Entities;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using Domain.Operations.Command.ProductTypeCommand;
using Domain.Operations.Query.ProductTypeQuery;


namespace aspnet5.Controllers
{
    [Route("api/[controller]")]
    public class ProductTypeController: Controller
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public ProductTypeController(
            IQueryDispatcher queryDispatcher
            , ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        public IEnumerable<ProductType> GetAll()
        {
            return _queryDispatcher
                .Dispatch<AllProductTypesQuery, ProductTypesQueryResult>(new AllProductTypesQuery()).Items;
        }

        [HttpGet("{id:int}")]
        public ProductType Get(long id)
        {
            return _queryDispatcher
                .Dispatch<ProductTypeIdsQuery, ProductTypesQueryResult>(new ProductTypeIdsQuery
                {
                    Ids = new[] { id }
                }).Items.First();
        }


        //Example: {"Name":"TV", "Attributes":[{"Name":"SmartTV", "Type":"boolean"}]}
        [HttpPost]
        public void AddProductType([FromBody] CreateProductTypeCommand command)
        {
            _commandDispatcher.Dispatch(command);
        }

    }
}
