
using System;


namespace Domain
{
    public class EventDto : IEventDto
    {
        public string Id { get;  set; }
        public string LocationId { get;  set; }
        public string Title { get;  set; }
        public bool Complated { get;  set; }

        public EventDto()
        {
            Id = Guid.NewGuid().ToString(); 
        }
        public EventDto(string locationId, string title, bool complated) : this()
        {
            LocationId = locationId;
            Title = title;
            Complated = complated;
        }
        public EventDto(string id,string locationId, string title, bool complated) : this(locationId,title,complated)
        {
            Id = id;
        }
    }
}
