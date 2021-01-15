
using System;


namespace Contracts.Dtos
{
    public class EventCreateDto 
    {
        public string Id { get;  set; }
        public string LocationId { get;  set; }
        public string Title { get;  set; }
        public bool Complated { get;  set; }

    }
}
