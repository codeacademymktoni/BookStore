using BookStore.Data;
using BookStore.ModelDtos;

namespace BookStore.Helpers
{
    public static class ModelConverter
    {
        public static BookDto ToBookDto(this Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Genre = book.Genre,
                Quantity = book.Quantity,
                Price = book.Price
            };
        }

        public static Book ToBookEntity(this BookDto book)
        {
            return new Book
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Genre = book.Genre,
                Quantity = book.Quantity,
                Price = book.Price
            };
        }
    }
}
