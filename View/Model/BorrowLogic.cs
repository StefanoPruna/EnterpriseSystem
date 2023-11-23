using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BorrowLogic
    {
        public List<Borrow> BorrowBookList()
        {
            BorrowDAO borrow = new BorrowDAO();
            List<Borrow> borrows = borrow.BorrowBookList();
            return borrows;
        }
        //public List<Borrow> ReservedBook(int userId, string iSbN, DateTime bookReserved)
        //{
        //    BorrowDAO borrow = new BorrowDAO();
        //    List<Borrow> borrows = borrow.ReservedBook(userId, iSbN, bookReserved);
        //    return borrows;
        //}
        public int BorrowBook(int id, string bookIsbn, DateTime dateBorrowed, DateTime dateReturned)
        {
            BorrowDAO borrowDAO = new BorrowDAO();
            int bookBorrowed = borrowDAO.BorrowBook(id, bookIsbn, dateBorrowed, dateReturned);
            return bookBorrowed;
        }
        public int ReservedBook(int userId, string iSbN, DateTime bookReserved)
        {
            BorrowDAO borrow = new BorrowDAO();
            DateTime dtReserved = Convert.ToDateTime(bookReserved);
            int borrows = borrow.ReservedBook(userId, iSbN, dtReserved);
            return borrows;
        }
        public List<Borrow> ShowReservedBook()
        {
            BorrowDAO borrow = new BorrowDAO();
            List<Borrow> borrowBook = borrow.ShowReservedBook();
            return borrowBook;
        }
        public int DeleteReserved(string bookIsbn)
        {
            BorrowDAO borrowDAO = new BorrowDAO();
            int deleteBorrow = borrowDAO.DeleteReserved(bookIsbn);
            return deleteBorrow;
        }
        public int DeleteBorrow(string bookIsbn)
        {
            BorrowDAO borrowDAO = new BorrowDAO();
            int deleteBorrow = borrowDAO.DeleteBorrow(bookIsbn);
            return deleteBorrow;
        }
    }
}
