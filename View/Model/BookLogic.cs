using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookLogic
    {
        public List<Books> GetAllBooks()
        {
            //The logic has to connected to the DAO
            BookDAO bookDAO = new BookDAO();
            List<Books> books = bookDAO.GetAllBooks();
            return books;
        }
       
        public List<Books> SearchBook(string booksName, int publishedYear)
        {
            BookDAO searchBookDAO = new BookDAO();
            List<Books> searchBook = searchBookDAO.SearchBook(booksName, publishedYear);
            return searchBook;
        }
    }
}
