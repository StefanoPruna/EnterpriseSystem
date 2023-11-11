using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BorrowLogic
    {
        public List<Borrow> BorrowBook()
        {
            BorrowDAO borrow = new BorrowDAO();
            List<Borrow> borrows = borrow.BorrowBook();
            return borrows;
        }
        public List<Borrow> ReserveBook()
        {
            BorrowDAO borrow = new BorrowDAO();
            List<Borrow> borrows = borrow.ReserveBook();
            return borrows;
        }
}
}
