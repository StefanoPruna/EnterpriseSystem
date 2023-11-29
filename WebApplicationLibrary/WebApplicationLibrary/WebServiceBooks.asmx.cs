using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationLibrary
{
    /// <summary>
    /// Summary description for WebServiceBooks
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBooks : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Books> GetAllBooks()
        {
            //Logic is connected to the Model
            BookLogic bookLogic = new BookLogic();
            List<Books> books = bookLogic.GetAllBooks();
            return books;
        }

        [WebMethod]
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
