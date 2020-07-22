using BookStore.Helpers;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        public async Task CreateAsync(BookDto bookDto)
        {
            var dbBook = bookDto.ToBookEntity();
            await booksRepository.CreateAsync(dbBook);
        }

        public void Delete(int id)
        {
            var dbBook = booksRepository.GetById(id);

            if (dbBook != null)
            {
                booksRepository.Delete(dbBook);
            }
        }

        public List<BookDto> GetAll()
        {
            var dbBooks = booksRepository.GetAll();
            return dbBooks.Select(x => x.ToBookDto()).ToList();
        }

        public List<BookDto> GetByAuthor(string author)
        {
            var dbBooks = booksRepository.GetByAuthor(author);
            return dbBooks.Select(x => x.ToBookDto()).ToList();
        }

        public BookDto GetById(int id)
        {
            var book = booksRepository.GetById(id);

            return book.ToBookDto();
        }

        public List<BookDto> GetByIds(List<int> bookIds)
        {
            var books = booksRepository.GetByIds(bookIds);
            return books.Select(x => x.ToBookDto()).ToList();
        }

        public void Update(BookDto bookDto)
        {
            var dbBook = booksRepository.GetById(bookDto.Id);

            if (dbBook != null)
            {
                dbBook.Title = bookDto.Title;
                dbBook.Description = bookDto.Description;
                dbBook.Author = bookDto.Author;
                dbBook.Genre = bookDto.Genre;
                dbBook.Price = bookDto.Price;
                dbBook.Quantity = bookDto.Quantity;

                booksRepository.Update(dbBook);
            }
        }
    }
}
