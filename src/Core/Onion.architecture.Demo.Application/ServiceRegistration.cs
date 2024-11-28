using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Onion.architecture.Demo.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assm=Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
        }
    }
}
