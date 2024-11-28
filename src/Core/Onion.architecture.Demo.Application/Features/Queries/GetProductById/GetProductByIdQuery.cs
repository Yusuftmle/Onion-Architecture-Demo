using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Onion.architecture.Demo.Application.Dto;
using Onion.architecture.Demo.Application.Wrappers;

namespace Onion.architecture.Demo.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }

    }
}
