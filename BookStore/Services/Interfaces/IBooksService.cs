using BookStore.ModelDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IBooksService
    {
        List<BookDto> GetAll();
        BookDto GetById(int id);
        List<BookDto> GetByAuthor(string author);
        Task CreateAsync(BookDto bookDto);
        void Delete(int id);
        void Update(BookDto bookDto);
        List<BookDto> GetByIds(List<int> bookIds);
    }
}
