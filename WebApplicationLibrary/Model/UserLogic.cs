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

        public int InsertNewUser(string userName, string password, int userLevel)
        {
            UserDAO userDAO = new UserDAO();

            int newUser = userDAO.InsertNewUser(userName, password, userLevel);

            return newUser;
        }
        public int UpdateUser(string updatedUserName, string updatedPassword, int updatedUserLevel, string originalUserName)
        {
            UserDAO userDAO = new UserDAO();

            int updateUser = userDAO.UpdateUser(updatedUserName, updatedPassword, updatedUserLevel, originalUserName);

            return updateUser;
        }

        public int DeleteUser(string userName) 
        {
            UserDAO userDAO = new UserDAO();

            int deleteUser = userDAO.DeleteUser(userName);

            return deleteUser;
        }
    }
}
