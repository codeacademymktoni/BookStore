using BookStore.ModelDtos;
using System.Collections.Generic;

namespace BookStore.Services.Interfaces
{
    public interface IBooksService
    {
        List<BookDto> GetAll();
        BookDto GetById(int id);
        List<BookDto> GetByAuthor(string author);
        void Create(BookDto bookDto);
        void Delete(int id);
        void Update(BookDto bookDto);
    }
}
