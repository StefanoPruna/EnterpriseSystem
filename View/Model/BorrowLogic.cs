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
            Borrow borrow = new Borrow();
            List<Borrow> borrows = borrow.BorrowBook();
            return borrows;
        }
    }
}
