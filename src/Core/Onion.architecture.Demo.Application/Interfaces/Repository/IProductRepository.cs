using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Architecture.Demo.Domain.Common;
using Onion.Architecture.Demo.Domain.Entities;

namespace Onion.architecture.Demo.Application.Interfaces.Repository
{
    public interface IProductRepository: IGenericRepositoryAsync<Product>
    {

    }
}
