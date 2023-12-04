using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BookController
    {
        public List<Books> GetAllBooks()
        {
            //Logic is connected to the local Model
            //BookLogic bookLogic = new BookLogic();
            //List<Books> books = bookLogic.GetAllBooks();

            //Connected via Cloud App
            ServiceReferenceBooks.WebServiceBooksSoapClient soapClient = new ServiceReferenceBooks.WebServiceBooksSoapClient();
            ServiceReferenceBooks.Books[] booksArray = soapClient.GetAllBooks();
            
            List<Books> books = new List<Books>();

            foreach( ServiceReferenceBooks.Books book in booksArray )            
            {
                Books books1 = new Books();
                books1.Isbn = book.Isbn;
                books1.BookName = book.BookName;
                books1.Author = book.Author;
                books1.Category = book.Category;
                books1.Language = book.Language;
                books1.PublishYear = book.PublishYear;
                books1.Pages = book.Pages;  
                books1.Publisher = book.Publisher;
                books.Add(books1 );
            }

            return books;
        }
       
        public List<Books> SearchBook(string booksName, int publishedYear, string publisherName)
        {
            //Logic is connected to the local Model
            //BookDAO searchBookDAO = new BookDAO();
            //List<Books> searchBook = searchBookDAO.SearchBook(booksName, publishedYear, publisherName);
            //BookLogic bookLogic = new BookLogic();
            //List<Books> searchBook = bookLogic.SearchBook(booksName, publishedYear, publisherName);

            //Connecting via Cloud App
            ServiceReferenceBooks.WebServiceBooksSoapClient soapClient = new ServiceReferenceBooks.WebServiceBooksSoapClient();
            ServiceReferenceBooks.Books[] booksArray = soapClient.SearchBook(booksName, publishedYear, publisherName);

            List<Books> searchBook = new List<Books>();

            foreach (ServiceReferenceBooks.Books book in booksArray)
            {
                Books books1 = new Books();
                books1.Isbn = book.Isbn;
                books1.BookName = book.BookName;
                books1.Author = book.Author;
                books1.Category = book.Category;
                books1.Language = book.Language;
                books1.PublishYear = book.PublishYear;
                books1.Pages = book.Pages;
                books1.Publisher = book.Publisher;
                searchBook.Add(books1);
            }

            return searchBook;
        }
    }
}
