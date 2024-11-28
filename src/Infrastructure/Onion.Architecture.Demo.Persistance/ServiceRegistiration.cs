using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Onion.architecture.Demo.Application.Interfaces.Repository;
using Onion.Architecture.Demo.Persistance.Context;
using Onion.Architecture.Demo.Persistance.Repository;

namespace Onion.Architecture.Demo.Persistance
{
    public static  class ServiceRegistiration
    {

        public static void AddPersistanceServices(this IServiceCollection servicecollection)
        {
            servicecollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            servicecollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
