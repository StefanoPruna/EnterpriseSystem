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
        public List<Borrow> BorrowBook()
        {
            TabBorrowTableAdapter adapter = new TabBorrowTableAdapter();
            DataSetBorrow.TabBorrowDataTable borrowDataTable = adapter.BorrowBook();

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
        public List<Borrow> ReserveBook()
        {
            TabReservedTableAdapter reservedTableAdapter = new TabReservedTableAdapter();
            DataSetBorrow.TabReservedDataTable reservedRows = reservedTableAdapter.ReserveBook();

            int dataCount = reservedRows.Count;
            List<Borrow> reserve = new List<Borrow>();

            if(dataCount != 0)
            {
                for (int i = 0; i < reservedRows.Rows.Count; i++) 
                {
                    Borrow reserveBook = new Borrow();
                    DataRow reservedDataRow = reservedRows.Rows[i];

                    int uid = Convert.ToInt32(reservedDataRow["UID"]);
                    string isbn = reservedDataRow["ISBN"].ToString();
                    DateTime reservedDate = Convert.ToDateTime(reservedDataRow["ReservedDate"]);

                    reserveBook.Uid = uid;
                    reserveBook.Isbn = isbn;
                    reserveBook.ReservedDate = reservedDate;                    

                    reserve.Add(reserveBook);
                }
                return reserve;
            }
            else
                return null;
        }
    }
}
