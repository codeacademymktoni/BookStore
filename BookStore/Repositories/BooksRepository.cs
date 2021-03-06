﻿using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreDbContext context;

        public BooksRepository(BookStoreDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Book dbBook)
        {
            context.Books.Add(dbBook);
            await context.SaveChangesAsync();
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

        public List<Book> GetByIds(List<int> bookIds)
        {
            return context.Books.Where(x => bookIds.Contains(x.Id)).ToList();
        }

        public void Update(Book updatedBook)
        {
            context.Books.Update(updatedBook);
            context.SaveChanges();
        }
    }
}
