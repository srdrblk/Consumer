
using System;


namespace Domain
{
    public interface IEventDto 
    {
        public string Id { get;  set; }
        public string LocationId { get;  set; }
        public string Title { get;  set; }
        public bool Complated { get;  set; }

 
    }
}
