using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetBookTableAdapters;

namespace Model
{
    //DAO = Data Access Object, accessing data from the database
    public class BookDAO
    {
        //We had to change from void to List, because we return the List of Books
        public List<Books> GetAllBooks()
        {
            //Connects to the Database and executing the Queries and it returns the data into the object tabBookDataTable
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            DataSetBook.TabBookDataTable tabBookDataTable = tabBookTableAdapter.GetAllBooks();

            //Traverse the tabBookDataTable and get all the data one by one (loop)
            //1st check if any data is returned
            int dataCount = tabBookDataTable.Count;
            if (dataCount != 0)
            {
                //create a List of Book objects
                List<Books> books = new List<Books>();                    

                foreach (DataRow row in tabBookDataTable)
                {
                    string isbn = row["ISBN"].ToString();
                    string bookName = row["BookName"].ToString();
                    int author = Convert.ToInt32(row["Author"]);
                    int category = Convert.ToInt32(row["Category"]);
                    int language = Convert.ToInt32(row["Language"]);
                    int publishYear = Convert.ToInt32(row["PublishYear"]);
                    int pages = Convert.ToInt32(row["Pages"]);
                    string publisher = row["Publisher"].ToString();

                    //encapsulate the above data into a Book Object
                    //so we need to create an Entity class called Book
                    Books book = new Books();
                    book.Isbn = isbn;
                    book.BookName = bookName;
                    book.Author = author;
                    book.Category = category;
                    book.Language = language;
                    book.PublishYear = publishYear;
                    book.Pages = pages;
                    book.Publisher = publisher;

                    //and then add that UO into a List with a loop
                    books.Add(book);
                }
                //return the List of UO
                return books;
            }
            else
                return null;
        }
    }
   
}
