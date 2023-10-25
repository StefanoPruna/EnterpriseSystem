using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserLogic
    {
        public List<User> GetAllUsers()
        {
            //The logic has to connected to the DAO
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.GetAllUsers();
            return users;
        }

        public User ValideLogin(string sUserName, string sPassword)
        {
            //The logic has to connected to the DAO
            UserDAO userDAO = new UserDAO();
            User user = userDAO.ValideLogin(sUserName, sPassword);
            return user;
        }
    }
}
