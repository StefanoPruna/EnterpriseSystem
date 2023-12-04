using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BorrowController
    {
        public List<Borrow> BorrowBookList()
        {
            //Connecting Locally
            //BorrowLogic borrowLogic = new BorrowLogic();
            //List<Borrow> borrowBook = borrowLogic.BorrowBookList();

            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            ServiceReferenceBorrow.Borrow[] borrowArray = soapClient.BorrowBookList();

            List<Borrow> borrowList = new List<Borrow>();

            foreach(ServiceReferenceBorrow.Borrow borrow in borrowArray)
            {
                Borrow borrow1 = new Borrow();
                
                borrow1.Bid = borrow.Bid;
                borrow1.Uid = borrow.Uid;
                borrow1.Isbn = borrow.Isbn;
                borrow1.BorrowDate = borrow.BorrowDate;
                borrow1.ReturnDate = borrow.ReturnDate;
                borrow1.ActualReturnDate = borrow.ActualReturnDate;
                borrow1.LateFee = borrow.LateFee;
                
                borrowList.Add(borrow1);
            }
            return borrowList;
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
            //BorrowLogic borrowLogic=new BorrowLogic();
            //int bookBorrowed = borrowLogic.BorrowBook(id, bookIsbn, dateBorrowed, dateReturned);

            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            int bookBorrowed = soapClient.BorrowBook(id, bookIsbn, dateBorrowed, dateReturned);

            return bookBorrowed;
        }
        public int ReservedBook(int userId, string iSbN, DateTime bookReserved)
        {
            //BorrowLogic borrowLogic = new BorrowLogic();

            ////string dateToReserve = bookReserved.ToString("g");

            //DateTime dtReserved = Convert.ToDateTime(bookReserved);
            ////int isNumber = Convert.ToInt32(iSbN);

            //int reservedBook = borrowLogic.ReservedBook(userId, iSbN, dtReserved);
            
            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            int reservedBook = soapClient.ReservedBook(userId, iSbN, bookReserved);

            return reservedBook;
        }
        public List<Borrow> ShowReservedBook()
        {
            //BorrowLogic borrowLogic = new BorrowLogic();
            //List<Borrow> borrowBook = borrowLogic.ShowReservedBook();

            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            ServiceReferenceBorrow.Borrow[] reserveArray = soapClient.ShowReservedBook();

            List<Borrow> reserved = new List<Borrow>();

            foreach(ServiceReferenceBorrow.Borrow reserve in reserveArray)
            {
                Borrow reserve2 = new Borrow();
                reserve2.Rid = reserve.Rid;
                reserve2.Uid = reserve.Uid;
                reserve2.Isbn = reserve.Isbn;
                reserve2.ReservedDate = reserve.ReservedDate;
                reserved.Add(reserve2);
            }
            return reserved;
        }
        public int DeleteReserved(string bookIsbn)
        {
            //BorrowLogic borrow = new BorrowLogic();
            //int deleteReserve = borrow.DeleteReserved(bookIsbn);
            
            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            int deleteReserve = soapClient.DeleteReserved(bookIsbn);

            return deleteReserve;
        }
        public int DeleteBorrow(string bookIsbn)
        {
            //BorrowLogic borrow = new BorrowLogic();
            //int deleteBorrow = borrow.DeleteBorrow(bookIsbn);

            //Connecting via Cloud App
            ServiceReferenceBorrow.WebServiceBorrowSoapClient soapClient = new ServiceReferenceBorrow.WebServiceBorrowSoapClient();
            int deleteBorrow = soapClient.DeleteBorrow(bookIsbn);

            return deleteBorrow;
        }
    }
}
