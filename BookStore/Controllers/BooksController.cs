using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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


        /// <summary>
        /// Returns all books
        /// </summary>
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<List<BookDto>> Get()
        {
            var books = booksService.GetAll();
            return Ok(books);
        }


        /// <summary>
        /// Returns book for given Id
        /// </summary>
        /// <response code="200">Returns list of BookDto items</response>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public ActionResult<BookDto> Get(int id)
        {
            var books = booksService.GetById(id);
            return Ok(books);
        }


        /// <summary>
        /// Returns lsit of books for given author
        /// </summary>
        [HttpGet]
        [Route("getByAuthor")]
        public ActionResult<List<BookDto>> Get(string author)
        {
            var books = booksService.GetByAuthor(author);
            return Ok(books);
        }


        /// <summary>
        /// Creates new book
        /// </summary>
        [HttpPost]
        [Authorize]
        public IActionResult Create(BookDto bookDto)
        {
            booksService.Create(bookDto);
            return Ok();
        }


        /// <summary>
        /// Deletes book for given Id
        /// </summary>
        [HttpDelete]
        [Route("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            booksService.Delete(id);
            return Ok();
        }

        /// <summary>
        /// Updates book
        /// </summary>
        [HttpPut]
        [Authorize]
        public IActionResult Update(BookDto bookDto)
        {
            booksService.Update(bookDto);
            return Ok();
        }
    }
}