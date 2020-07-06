using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreDbContext context;

        public BooksRepository(BookStoreDbContext context)
        {
            this.context = context;
        }

        public void Create(Book dbBook)
        {
            context.Books.Add(dbBook);
            context.SaveChanges();
        }

        public void Delete(Book dbBook)
        {
            context.Books.Remove(dbBook);
            context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public List<Book> GetByAuthor(string author)
        {
            return context.Books.Where(x => x.Author == author).ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book updatedBook)
        {
            context.Books.Update(updatedBook);
            context.SaveChanges();
        }
    }
}
