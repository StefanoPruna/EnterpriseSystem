using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Controller
{
    public class UserController
    {
        public List<User> GetAllUsers()
        {
            //Logic is connected to the Model
            UserLogic userLogic = new UserLogic();
            List<User> users = userLogic.GetAllUsers();
            return users;
        }

        public User ValideLogin(string sUserName, string sPassword)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.ValideLogin(sUserName, sPassword);
            User user = userLogic.ValideLogin(sUserName, sPassword);
            return user;
        }

        public int InsertNewUser(string userName, string password, int userLevel)
        {
            UserLogic userLogic = new UserLogic();
            
            int newUser = userLogic.InsertNewUser(userName, password, userLevel);

            return newUser;
        }

        public int UpdateUser(string updatedUserName, string updatedPassword, int updatedUserLevel, string originalUserName)
        {
            UserLogic userLogic = new UserLogic();

            int updateUser = userLogic.UpdateUser(updatedUserName, updatedPassword, updatedUserLevel, originalUserName);

            return updateUser;
        }

        public int DeleteUser(string userName) 
        {
            UserLogic userLogic = new UserLogic();

            int deleteUser = userLogic.DeleteUser(userName);

            return deleteUser;
        }
    }
}
