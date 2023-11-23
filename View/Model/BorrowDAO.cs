using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetBorrowTableAdapters;
using Model.DataSetUserTableAdapters;

namespace Model
{
    public class BorrowDAO
    {
        public List<Borrow> BorrowBookList()
        {
            TabBorrowTableAdapter adapter = new TabBorrowTableAdapter();
            DataSetBorrow.TabBorrowDataTable borrowDataTable = adapter.BorrowBookList();

            int dataCount = borrowDataTable.Count;
            if (dataCount != 0)
            {
                List<Borrow> borrows = new List<Borrow>();
                foreach (DataRow row in borrowDataTable)
                {
                    int bid = Convert.ToInt32(row["BID"]);
                    int uid = Convert.ToInt32(row["UID"]);
                    string isbn = row["ISBN"].ToString();
                    DateTime borrowDate = Convert.ToDateTime(row["BorrowDate"]);
                    DateTime returnDate = Convert.ToDateTime(row["ReturnDate"]);
                    DateTime actualReturnDate = Convert.ToDateTime(row["ActualReturnDate"]);
                    decimal lateFee = Convert.ToDecimal(row["LateFee"]);

                    Borrow borrow = new Borrow();
                    borrow.Uid = uid;
                    borrow.Isbn = isbn;
                    borrow.Bid = bid;
                    borrow.ReturnDate = returnDate;
                    borrow.BorrowDate = borrowDate;
                    borrow.ActualReturnDate = actualReturnDate;
                    borrow.LateFee = lateFee;

                    borrows.Add(borrow);
                }
                return borrows;
            }
            else
                return null;
        }
        public int BorrowBook(int id, string bookIsbn, DateTime dateBorrowed, DateTime dateReturned)
        {
            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();
            string dtBorrowed = Convert.ToString(dateBorrowed);
            string dtReturned = Convert.ToString(dateReturned);
            int bookBorrowed = tabBorrowTableAdapter.BorrowBook(id, bookIsbn, dtBorrowed, dtReturned);
            return bookBorrowed;
        }
        public int ReservedBook(int userId, string iSbN, DateTime bookReserved)
        {
            TabReservedTableAdapter reservedTableAdapter = new TabReservedTableAdapter();
            //DateTime dtReserved = Convert.ToDateTime(bookReserved);
            string dtReserved = Convert.ToString(bookReserved.ToString());

            int borrows = reservedTableAdapter.ReservedBook(userId, iSbN, dtReserved);
            return borrows;
        }
        public List<Borrow> ShowReservedBook()
        {
            TabReservedTableAdapter adapter = new TabReservedTableAdapter();
            
            DataSetBorrow.TabReservedDataTable borrowDataTable = adapter.ShowReservedBook();

            int dataCount = borrowDataTable.Count;
            if (dataCount != 0)
            {
                List<Borrow> borrows = new List<Borrow>();
                foreach (DataRow row in borrowDataTable)
                {
                    int rid = Convert.ToInt32(row["RID"]);
                    int uid = Convert.ToInt32(row["UID"]);
                    string isbn = row["ISBN"].ToString();
                    DateTime reservedDate = Convert.ToDateTime(row["ReservedDate"]);

                    Borrow borrow = new Borrow();
                    borrow.Uid = uid;
                    borrow.Isbn = isbn;
                    borrow.Rid = rid;
                    borrow.ReservedDate = reservedDate;

                    borrows.Add(borrow);
                }
                return borrows;
            }
            else
                return null;
        }
        public int DeleteReserved(string bookIsbn)
        {
            TabReservedTableAdapter deleteReserved = new TabReservedTableAdapter();
            int deleteReserve = deleteReserved.DeleteReserved(bookIsbn);
            return deleteReserve;
        }
        public int DeleteBorrow(string bookIsbn)
        {
            TabBorrowTableAdapter deleteBorrowed = new TabBorrowTableAdapter();
            int deleteBorrow = deleteBorrowed.DeleteBorrow(bookIsbn);
            return deleteBorrow;
        }
    }
}
