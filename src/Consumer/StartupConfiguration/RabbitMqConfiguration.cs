using Business.Consumer;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.StartupConfiguration
{

    public static class RabbitMqConfiguration
    {
        public static IServiceCollection RabbitMq(this IServiceCollection services, IConfiguration section)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<EventConsumer>();

                x.SetKebabCaseEndpointNameFormatter();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.ConfigureEndpoints(context);
                });
            });

            services.AddMassTransitHostedService();

            //services.AddMassTransit(x =>
            //{
            //    x.UsingRabbitMq();
            //});


            return services;
        }
    }

}
