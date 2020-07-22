using BookStore.Data;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
        Application GetByApiKey(string apikey);
        Task<Application> GetByApiKeyAsync(string apikey);
    }
}
