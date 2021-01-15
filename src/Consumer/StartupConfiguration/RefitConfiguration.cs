using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Refit;
using Business.Interfaces;

namespace Consumer.StartupConfiguration
{

    public static class RefitConfiguration
    {
        public static IServiceCollection Refit(this IServiceCollection services, IConfiguration section)
        {
            var eventApiUrl = section.GetSection("Urls:EventApiUrl").Value;
            services.AddRefitClient<IEventApiService>()
                .ConfigureHttpClient(config =>
                {
                    config.BaseAddress = new Uri(eventApiUrl);
                    config.Timeout = TimeSpan.FromMinutes(2);
                });

            return services;
        }
    }

}
