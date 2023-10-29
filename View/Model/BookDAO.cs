using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetBookTableAdapters;
using static Model.DataSetBook;

namespace Model
{
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

        public List<Books> SearchBook(string booksName, int publishedYear)
        {
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            DataSetBook.TabBookDataTable tabBookDataTable = tabBookTableAdapter.SearchBook(booksName, publishedYear.ToString());

            //Traverse the tabBookDataTable and get all the data one by one (loop)
            //1st check if any data is returned
            int dataCount = tabBookDataTable.Count;

            // This is the result container 
            List<Books> searchedBooks = new List<Books>();

            if (dataCount != 0)
            {
                for (int i = 0; i < tabBookDataTable.Rows.Count; i++)
                {
                    Books book = new Books();

                    DataRow bookDataRow = tabBookDataTable.Rows[i];

                    string isbn = bookDataRow["ISBN"].ToString();
                    string bookName = bookDataRow["BookName"].ToString();
                    int author = Convert.ToInt32(bookDataRow["Author"]);
                    int category = Convert.ToInt32(bookDataRow["Category"]);
                    int language = Convert.ToInt32(bookDataRow["Language"]);
                    int publishYear = Convert.ToInt32(bookDataRow["PublishYear"]);
                    int pages = Convert.ToInt32(bookDataRow["Pages"]);
                    string publisher = bookDataRow["Publisher"].ToString();

                    book.Isbn = isbn; //bookDataRow["ISBN"].ToString();
                    book.BookName = bookName;// bookDataRow["BookName"].ToString();
                    book.Author = author; // Convert.ToInt32(bookDataRow["Author"]);
                    book.Category = category;// Convert.ToInt32(bookDataRow["Category"]);
                    book.Language = language;// Convert.ToInt32(bookDataRow["Language"]);
                    book.PublishYear = publishedYear;// Convert.ToInt32(bookDataRow["PublishYear"]);
                    book.Pages = pages;// Convert.ToInt32(bookDataRow["Pages"]);
                    book.Publisher = publisher;// bookDataRow["Publisher"].ToString();             

                    searchedBooks.Add(book);
                }
                   
                return searchedBooks;
            }
            else
                return null;
        }        
    }
}
