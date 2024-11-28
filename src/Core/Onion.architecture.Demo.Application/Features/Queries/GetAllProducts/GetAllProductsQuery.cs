using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Onion.architecture.Demo.Application.Dto;
using Onion.architecture.Demo.Application.Interfaces.Repository;
using Onion.architecture.Demo.Application.Wrappers;

namespace Onion.architecture.Demo.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<ServiceResponse <List<ProductViewDto>>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public class GetAllProductsQueryHnadler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public GetAllProductsQueryHnadler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = productRepository.GetAllAsync();
                var viewmodel=mapper.Map <List<ProductViewDto>>(products);

                return new ServiceResponse<List<ProductViewDto>>(viewmodel);
            }

           
        }
    }
}
