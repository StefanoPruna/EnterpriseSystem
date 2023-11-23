using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Model.DataSetBorrowTableAdapters;

namespace Controller
{
    public class BorrowController
    {
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
        public int BorrowBook(int id, string bookIsbn, DateTime dateBorrowed, DateTime dateReturned)
        {
            BorrowLogic borrowLogic=new BorrowLogic();
            int bookBorrowed = borrowLogic.BorrowBook(id, bookIsbn, dateBorrowed, dateReturned);
            return bookBorrowed;
        }
        public int ReservedBook(int userId, string iSbN, DateTime bookReserved)
        {
            BorrowLogic borrowLogic = new BorrowLogic();

            //string dateToReserve = bookReserved.ToString("g");

            DateTime dtReserved = Convert.ToDateTime(bookReserved);
            //int isNumber = Convert.ToInt32(iSbN);

            int reservedBook = borrowLogic.ReservedBook(userId, iSbN, dtReserved);
            return reservedBook;
        }
        public List<Borrow> ShowReservedBook()
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowBook = borrowLogic.ShowReservedBook();
            return borrowBook;
        }
        public int DeleteReserved(string bookIsbn)
        {
            BorrowLogic borrow = new BorrowLogic();
            int deleteReserve = borrow.DeleteReserved(bookIsbn);
            return deleteReserve;
        }
        public int DeleteBorrow(string bookIsbn)
        {
            BorrowLogic borrow = new BorrowLogic();
            int deleteBorrow = borrow.DeleteBorrow(bookIsbn);
            return deleteBorrow;
        }
    }
}
