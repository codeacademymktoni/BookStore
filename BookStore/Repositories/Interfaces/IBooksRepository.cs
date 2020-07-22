using BookStore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthor(string author);
        Task CreateAsync(Book dbBook);
        void Delete(Book bdBook);
        void Update(Book updatedBook);
        List<Book> GetByIds(List<int> bookIds);
    }
}
