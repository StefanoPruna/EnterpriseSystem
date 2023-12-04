using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Books
    {
        string isbn;
        string bookName;
        int author;
        int category;
        int language;
        int publishYear;
        int pages;
        string publisher;
        
        public string Isbn { get => isbn; set => isbn = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public int Author { get => author; set => author = value; }
        public int Category { get => category; set => category = value; }
        public int Language { get => language; set => language = value; }
        public int PublishYear { get => publishYear; set => publishYear = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Publisher { get => publisher; set => publisher = value; }
    }
}
