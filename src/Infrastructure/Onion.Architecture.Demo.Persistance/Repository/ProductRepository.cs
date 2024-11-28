using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.architecture.Demo.Application.Interfaces.Repository;
using Onion.Architecture.Demo.Domain.Entities;
using Onion.Architecture.Demo.Persistance.Context;

namespace Onion.Architecture.Demo.Persistance.Repository
{
    public class ProductRepository:IGenericRepositoryAsync<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }

    }
}
