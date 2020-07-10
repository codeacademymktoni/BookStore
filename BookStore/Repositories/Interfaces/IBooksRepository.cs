using BookStore.Data;
using System.Collections.Generic;

namespace BookStore.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthor(string author);
        void Create(Book dbBook);
        void Delete(Book bdBook);
        void Update(Book updatedBook);
        List<Book> GetByIds(List<int> bookIds);
    }
}
