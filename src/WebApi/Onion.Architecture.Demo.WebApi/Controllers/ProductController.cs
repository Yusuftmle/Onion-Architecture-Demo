using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.architecture.Demo.Application.Dto;
using Onion.architecture.Demo.Application.Features.Commands.CreateProduct;
using Onion.architecture.Demo.Application.Features.Queries.GetAllProducts;
using Onion.architecture.Demo.Application.Features.Queries.GetProductById;
using Onion.architecture.Demo.Application.Interfaces.Repository;

namespace Onion.Architecture.Demo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpPost]

        public async Task<IActionResult> CreateProduct(CreateProductComand comand)
        {

            return Ok(await mediator.Send(comand));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByID(Guid Id)
        {
            var query=new GetProductByIdQuery() { Id=Id};
            return Ok(await mediator.Send(query));
            
        }


    }
}
