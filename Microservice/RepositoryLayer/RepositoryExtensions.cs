using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            return services
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
                      

        }
    }
}
