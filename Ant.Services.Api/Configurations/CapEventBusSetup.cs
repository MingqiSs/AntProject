using Ant.Infra.Data.Context;
using Ant.Services.Api.IntegrationEvents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ant.Services.Api.Configurations
{
    public static class CapEventBusSetup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {

           services.AddTransient<ISubscriberService, SubscriberService>();
            services.AddCap(x =>
            {
                x.UseEntityFramework<AntContext>();
                x.UseRabbitMQ(q =>
                {
                    configuration.GetSection("RabbitMQ").Bind(q);
                });
               // x.UseDashboard();
            });

            //return services;
        }
    }
}
