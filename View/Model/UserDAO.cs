using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetUserTableAdapters;

namespace Model
{
    //DAO = Data Access Object, accessing data from the database
    public class UserDAO
    {
        //We had to change from void to List, because we return the List of Users
        public List<User> GetAllUsers()
        {
            //Connects to the Database and executing the Queries and it returns the data into the object tabUserDataTable
            TabUserTableAdapter tabUserTableAdapter = new TabUserTableAdapter();
            DataSetUser.TabUserDataTable tabUserDataTable =  tabUserTableAdapter.GetAllUsers();//this GetAllUsers function will run the SQL

            //Traverse the tabUserDataTable and get all the data one by one (loop)
            //1st check if any data is returned
            int dataCount = tabUserDataTable.Count;
            if (dataCount != 0)
            {
                //create a List of User objects
                List<User> users = new List<User>();    

                foreach (DataRow row in tabUserDataTable)
                {
                    int uid = Convert.ToInt32(row["UID"]);
                    string userName = row["UserName"].ToString();
                    string password = row["Password"].ToString();
                    int userLevel = Convert.ToInt32(row["UserLevel"]);

                    //encapsulate the above data into a User Object
                    //so we need to create an Entity class called User
                    User user = new User();
                    user.Uid = uid;
                    user.UserName = userName;
                    user.Password = password;
                    user.UserLevel = userLevel;                                    
                   
                    //and then add that UO into a List with a loop
                    users.Add(user);
                }
                //return the List of UO
                return users;
            }
            else
                return null;
        }
    }
}
