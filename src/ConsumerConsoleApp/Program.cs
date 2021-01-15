using Business.Consumer;
using MassTransit;
using System;

namespace ConsumerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.ReceiveEndpoint("event-listener", e =>
                {
                    e.Consumer<EventConsumer>();
                });
            });

            busControl.Start();
            Console.WriteLine("Started consuming.");
        }
    }
}
