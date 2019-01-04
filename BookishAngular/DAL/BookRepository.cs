using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookishAngular.Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace BookishAngular.DAL
{
    public class BookRepository : IBookRepository
    {
        private IDbConnection _db = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultMySQLConnection"].ConnectionString);

        public List<Book> GetBooks()
        {
            return _db.Query<Book>("SELECT * FROM books").ToList();
        }

        public Book GetSingleBook(int bookId)
        {
            return _db.Query<Book>("SELECT * FROM books WHERE id = @bookId", new {bookId = bookId}).Single();
        }

        public bool InsertBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}