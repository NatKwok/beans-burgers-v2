using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;
using BeansBurgers_v2.Application;
using BeansBurgers_v2.Contracts;

namespace BeansBurgers_v2
{
    //this is responsible for registering all services we need to make Stripe work at our backend
    public static class StripeInfrastructure
    {
        public static IServiceCollection AddStripeInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            StripeConfiguration.ApiKey = configuration.GetValue<string>("StripeSettings:SecretKey");

            return services
                .AddScoped<CustomerService>()
                .AddScoped<ChargeService>()
                .AddScoped<TokenService>()
                .AddScoped<IStripeAppService, StripeAppService>();
        }
    }
}
