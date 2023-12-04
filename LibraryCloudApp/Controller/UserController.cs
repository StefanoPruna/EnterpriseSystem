using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserController
    {
        public List<User> GetAllUsers()
        {
            //Logic is connected to the Model
            //UserLogic userLogic = new UserLogic();
            //List<User> users = userLogic.GetAllUsers();

            //Connect to the Cloud application
            //ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            ////List<ServiceReferenceLogin.User> user = new List<ServiceReferenceLogin.User>();
            //ServiceReferenceLogin.User[] user = soapClient.GetAllUsers();

            ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            ServiceReferenceLogin.User[] usersArray = soapClient.GetAllUsers();

            List<User> users = new List<User>();

            foreach (ServiceReferenceLogin.User tempUser in usersArray)
            {
                User user = new User();
                user.Uid = tempUser.Uid;
                user.UserName = tempUser.UserName;
                user.Password = tempUser.Password;
                user.UserLevel = tempUser.UserLevel;
                users.Add(user);
            }
            
            return users;
        }

        public User ValideLogin(string sUserName, string sPassword)
        {
            //Local connection
            //UserLogic userLogic = new UserLogic();
            //userLogic.ValideLogin(sUserName, sPassword);
            //User user = userLogic.ValideLogin(sUserName, sPassword);
            //return user;                       

            //Cloud App connection
            ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            ServiceReferenceLogin.User tempUser = soapClient.ValideLogin(sUserName, sPassword);

            User user = new User();
            

            if (sUserName == "" || sPassword == "")
                Console.WriteLine("Your login is incorrect");
            else if (user.UserName != sUserName || user.Password != sPassword)
                Console.WriteLine("Your login is incorrect");
            else
            {
                user.UserName = tempUser.UserName;
                user.Password = tempUser.Password;
                user.UserLevel = tempUser.UserLevel;

                return user;
            }
            return null;
        }

        public int InsertNewUser(string userName, string password, int userLevel)
        {
            //Local connection
            //UserLogic userLogic = new UserLogic();            
            //int newUser = userLogic.InsertNewUser(userName, password, userLevel);

            //Cloud App connection
            ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            int newUser = soapClient.InsertNewUser(userName, password, userLevel);

            return newUser;
        }

        public int UpdateUser(string updatedUserName, string updatedPassword, int updatedUserLevel, string originalUserName)
        {
            //Local connection
            //UserLogic userLogic = new UserLogic();
            //int updateUser = userLogic.UpdateUser(updatedUserName, updatedPassword, updatedUserLevel, originalUserName);

            //Cloud App connection
            ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            int updateUser = soapClient.UpdateUser(updatedUserName, updatedPassword, updatedUserLevel, originalUserName);   
            
            return updateUser;
        }

        public int DeleteUser(string userName) 
        {
            //Local connection
            //UserLogic userLogic = new UserLogic();
            //int deleteUser = userLogic.DeleteUser(userName);

            //Cloud App connection
            ServiceReferenceLogin.WebServiceLibrarySoapClient soapClient = new ServiceReferenceLogin.WebServiceLibrarySoapClient();
            int deleteUser = soapClient.DeleteUser(userName);
            
            return deleteUser;
        }
    }
}
