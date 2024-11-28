using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Onion.architecture.Demo.Application.Dto;
using Onion.architecture.Demo.Application.Features.Commands.CreateProduct;
using Onion.architecture.Demo.Application.Features.Queries.GetProductById;
using Onion.Architecture.Demo.Domain.Entities;

namespace Onion.architecture.Demo.Application.Mapping
{
    public class GeneralMapping:Profile
    {

        public GeneralMapping()
        {
            CreateMap<Product,ProductViewDto>()
                .ReverseMap();
            CreateMap<Product,CreateProductComand>()
                .ReverseMap();

            CreateMap<Product, GetProductByIdViewModel>()
               .ReverseMap();

        }

    }
}
