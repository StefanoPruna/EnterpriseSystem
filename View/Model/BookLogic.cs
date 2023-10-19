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
    }
}
