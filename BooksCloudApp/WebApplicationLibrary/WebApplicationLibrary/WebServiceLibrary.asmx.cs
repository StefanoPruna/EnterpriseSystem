using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationLibrary
{
    /// <summary>
    /// Summary description for WebServiceLibrary
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLibrary : System.Web.Services.WebService
    {

        [WebMethod]
        public User ValideLogin(string sUserName, string sPassword)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.ValideLogin(sUserName, sPassword);
            User user = userLogic.ValideLogin(sUserName, sPassword);
            return user;
        }

        [WebMethod]
        public List<User> GetAllUsers()
        {
            //Logic is connected to the Model
            UserLogic userLogic = new UserLogic();
            List<User> users = userLogic.GetAllUsers();
            return users;
        }

        [WebMethod]
        public int InsertNewUser(string userName, string password, int userLevel)
        {
            UserLogic userLogic = new UserLogic();

            int newUser = userLogic.InsertNewUser(userName, password, userLevel);

            return newUser;
        }

        [WebMethod]
        public int UpdateUser(string updatedUserName, string updatedPassword, int updatedUserLevel, string originalUserName)
        {
            UserLogic userLogic = new UserLogic();

            int updateUser = userLogic.UpdateUser(updatedUserName, updatedPassword, updatedUserLevel, originalUserName);

            return updateUser;
        }

        [WebMethod]
        public int DeleteUser(string userName)
        {
            UserLogic userLogic = new UserLogic();

            int deleteUser = userLogic.DeleteUser(userName);

            return deleteUser;
        }        
    }
}
