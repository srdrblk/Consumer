
using Domain;
using Refit;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEventApiService
    {
        [Post("/Event")]
        Task PostEvent(IEventDto createEvent);
    }
}
