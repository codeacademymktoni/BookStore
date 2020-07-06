using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService booksService;

        public BooksController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = booksService.GetAll();
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var books = booksService.GetById(id);
            return Ok(books);
        }

        [HttpGet]
        [Route("getByAuthor")]
        public IActionResult Get(string author)
        {
            var books = booksService.GetByAuthor(author);
            return Ok(books);
        }

        [HttpPost]
        public IActionResult Create(BookDto bookDto)
        {
            booksService.Create(bookDto);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            booksService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(BookDto bookDto)
        {
            booksService.Update(bookDto);
            return Ok();
        }
    }
}