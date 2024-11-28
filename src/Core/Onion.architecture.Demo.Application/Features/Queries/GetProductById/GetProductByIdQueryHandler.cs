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

namespace Onion.architecture.Demo.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IProductRepository productRepository;
        private readonly Mapper mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,Mapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

       

      

        async Task<ServiceResponse<GetProductByIdViewModel>> IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>.Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
           
            var products = await productRepository.GetByIdAsync(request.Id);

            var dto = mapper.Map<GetProductByIdViewModel>(products);

            return new ServiceResponse<GetProductByIdViewModel>(dto);

        }
    }
}
