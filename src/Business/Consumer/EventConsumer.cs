using Business.Interfaces;
using Domain;
using MassTransit;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Consumer
{

    public class EventConsumer : IConsumer<EventDto>
    {
        IEventApiService eventApiService;
        public EventConsumer(IEventApiService _eventApiService)
        {
            eventApiService = _eventApiService;
        }
        public async Task Consume(ConsumeContext<EventDto> context)
        {
          
            eventApiService.PostEvent(context.Message);
        }
    }


}
