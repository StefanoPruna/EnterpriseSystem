using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetUserTableAdapters;

namespace Model
{
    //DAO = Data Access Object
    public class UserDAO
    {
        public void GetAllUsers()
        {
            //Connects to the Database
            TabUserTableAdapter tabUserTableAdapter = new TabUserTableAdapter();
            DataSetUser.TabUserDataTable tabUserDataTable =  tabUserTableAdapter.GetAllUsers();
        }
    }
}
