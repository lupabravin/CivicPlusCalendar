using CivicPlusCalendar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CivicPlusCalendar.Services.Interfaces
{
    public interface IEventService
    {
        Task<List<EventViewModel>> GetEvents();
        Task<EventViewModel> PostEvent(EventViewModel eventModel);
    }
}
