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

        public void ValideLogin(string sUserName, string sPassword)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.ValideLogin(sUserName, sPassword);
        }
    }
}
