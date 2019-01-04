using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookishAngular.Models;

namespace BookishAngular.DAL
{
    internal interface IBookRepository
    {
        List<Book> GetBooks();

        Book GetSingleBook(int bookId);

        bool InsertBook(Book book);

        bool DeleteBook(int bookId);

        bool UpdateBook(Book book);
    }
}
