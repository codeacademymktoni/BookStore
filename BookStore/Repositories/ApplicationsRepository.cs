using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System.Linq;

namespace BookStore.Repositories
{
    public class ApplicationsRepository : IApplicationRepository
    {
        private readonly BookStoreDbContext context;

        public ApplicationsRepository(BookStoreDbContext context)
        {
            this.context = context;
        }

        public Application GetByApiKey(string apikey)
        {
            return context.Applications.FirstOrDefault(x => x.ApiKey.Equals(apikey));
        }
    }
}
