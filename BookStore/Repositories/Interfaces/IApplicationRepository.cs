using BookStore.Data;

namespace BookStore.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
        Application GetByApiKey(string apikey);
    }
}
