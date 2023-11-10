using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Controller
{
    public class BorrowController
    {
        public List<Borrow> BorrowBook()
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowBook = borrowLogic.BorrowBook();
            return borrowBook;
        }
    }
}
