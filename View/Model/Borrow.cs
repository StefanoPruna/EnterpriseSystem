using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Borrow
    {
        int bid;
        int uid;
        string isbn;
        DateTime borrowDate;
        DateTime returnDate;
        DateTime actualReturnDate;
        decimal lateFee;
        DateTime reservedDate;

        public int Bid { get => bid; set => bid = value; }
        public int Uid { get => uid; set => uid = value; }
        
        public string Isbn { get => isbn; set => isbn = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public DateTime ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public decimal LateFee { get => lateFee; set => lateFee = value; }
        public DateTime ReservedDate { get => reservedDate; set => reservedDate = value; }
    }
}
