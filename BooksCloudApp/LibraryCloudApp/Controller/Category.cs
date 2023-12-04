using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Category
    {
        int cid;
        string categoryName;

        public int Cid { get => cid; set => cid = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
