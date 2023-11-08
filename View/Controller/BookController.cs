using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Controller
{
    public class BookController
    {
        public List<Books> GetAllBooks()
        {
            //Logic is connected to the Model
            BookLogic bookLogic = new BookLogic();
            List<Books> books = bookLogic.GetAllBooks();
            return books;
        }
       
        public List<Books> SearchBook(string booksName, int publishedYear, string publisherName)
        {
            //BookDAO searchBookDAO = new BookDAO();
            //List<Books> searchBook = searchBookDAO.SearchBook(booksName, publishedYear, publisherName);
            BookLogic bookLogic = new BookLogic();
            List<Books> searchBook = bookLogic.SearchBook(booksName, publishedYear, publisherName);

            return searchBook;
        }
    }
}
