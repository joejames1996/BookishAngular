using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookishAngular.DAL;
using BookishAngular.Models;

namespace BookishAngular.Controllers
{
    public class BookController : ApiController
    {
        private BookRepository _bookRepository = new BookRepository();

        // GET: api/Book
        [Route("Books/")]
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.GetBooks();
        }

        // GET: api/Book/5
        [Route("Books/{id}")]
        [HttpGet]
        public Book Get(int id)
        {
            return _bookRepository.GetSingleBook(id);
        }

        // POST: api/Book
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}
