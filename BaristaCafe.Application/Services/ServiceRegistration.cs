using BaristaCafe.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(
                typeof(ServiceRegistration).Assembly));
        }
       
    }
}
