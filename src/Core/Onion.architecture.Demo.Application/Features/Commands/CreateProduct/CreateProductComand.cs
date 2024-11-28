using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Onion.architecture.Demo.Application.Interfaces.Repository;
using Onion.architecture.Demo.Application.Wrappers;
using Onion.Architecture.Demo.Domain.Entities;

namespace Onion.architecture.Demo.Application.Features.Commands.CreateProduct
{
    public class CreateProductComand :IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }

        public int Quantity { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateProductComand, ServiceResponse<Guid>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public  async Task<ServiceResponse<Guid>> Handle(CreateProductComand request, CancellationToken cancellationToken)
            {
                var product=mapper.Map<Product>(request);
                   await productRepository.AddAsync(product);

                return new ServiceResponse<Guid>(product.Id);
            }
        }


    }
}
