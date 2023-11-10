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
                    float borrowDate = Convert.ToInt32(row["BorrowDate"]);
                    float returnDate = Convert.ToInt32(row["ReturnDate"]);
                    float actualReturnDate = Convert.ToInt32(row["ActualReturnDate"]);
                    double lateFee = Convert.ToInt32(row["LateFee"]);

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
    }
}
