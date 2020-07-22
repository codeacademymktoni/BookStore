using BookStore.Data;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<Application> GetByApiKeyAsync(string apikey)
        {
            return await context.Applications.FirstOrDefaultAsync(x => x.ApiKey.Equals(apikey));
        }
    }
}
