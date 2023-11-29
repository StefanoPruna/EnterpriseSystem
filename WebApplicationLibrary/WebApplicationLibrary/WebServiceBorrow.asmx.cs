using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationLibrary
{
    /// <summary>
    /// Summary description for WebServiceBorrow
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBorrow : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Borrow> BorrowBookList()
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowBook = borrowLogic.BorrowBookList();
            return borrowBook;
        }
        //public List<Borrow> ReservedBook(int userId, string iSbN, DateTime bookReserved)
        //{
        //    BorrowLogic borrowLogic = new BorrowLogic();
        //    List<Borrow> borrowBook = borrowLogic.ReservedBook(userId, iSbN, bookReserved);

        //    //string dateToReserve = bookReserved.ToString("g");

        //    //DateTime dtReserved = Convert.ToDateTime(bookReserved);
        //    //int isNumber = Convert.ToInt32(iSbN);


        //    return borrowBook;
        //}

        [WebMethod]
        public int BorrowBook(int id, string bookIsbn, DateTime dateBorrowed, DateTime dateReturned)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            int bookBorrowed = borrowLogic.BorrowBook(id, bookIsbn, dateBorrowed, dateReturned);
            return bookBorrowed;
        }

        [WebMethod]
        public int ReservedBook(int userId, string iSbN, DateTime bookReserved)
        {
            BorrowLogic borrowLogic = new BorrowLogic();

            //string dateToReserve = bookReserved.ToString("g");

            DateTime dtReserved = Convert.ToDateTime(bookReserved);
            //int isNumber = Convert.ToInt32(iSbN);

            int reservedBook = borrowLogic.ReservedBook(userId, iSbN, dtReserved);
            return reservedBook;
        }

        [WebMethod]
        public List<Borrow> ShowReservedBook()
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowBook = borrowLogic.ShowReservedBook();
            return borrowBook;
        }

        [WebMethod]
        public int DeleteReserved(string bookIsbn)
        {
            BorrowLogic borrow = new BorrowLogic();
            int deleteReserve = borrow.DeleteReserved(bookIsbn);
            return deleteReserve;
        }

        [WebMethod]
        public int DeleteBorrow(string bookIsbn)
        {
            BorrowLogic borrow = new BorrowLogic();
            int deleteBorrow = borrow.DeleteBorrow(bookIsbn);
            return deleteBorrow;
        }
    }
}
