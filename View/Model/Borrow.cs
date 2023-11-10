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
        float borrowDate;
        float returnDate;
        float actualReturnDate;
        double lateFee;

        public int Bid { get => bid; set => bid = value; }
        public int Uid { get => uid; set => uid = value; }
        public float BorrowDate { get => borrowDate; set => borrowDate = value; }
        public float ReturnDate { get => returnDate; set => returnDate = value; }
        public float ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public double LateFee { get => lateFee; set => lateFee = value; }
        public string Isbn { get => isbn; set => isbn = value; }
    }
}
