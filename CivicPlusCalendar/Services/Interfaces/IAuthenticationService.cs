using System.Threading.Tasks;

namespace CivicPlusCalendar.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> GetToken();
    }
}
