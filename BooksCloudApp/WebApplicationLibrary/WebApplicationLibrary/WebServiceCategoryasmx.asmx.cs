using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationLibrary
{
    /// <summary>
    /// Summary description for WebServiceCategoryasmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCategoryasmx : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Category> ShowCategory()
        {
            //Connecting locally
            CategoryLogic categoryLogic = new CategoryLogic();
            List<Category> categories = categoryLogic.ShowCategory();

            return categories;
        }
        [WebMethod]
        public int SaveCategory(string categoryNames)
        {
            //Connecting locally
            CategoryLogic categoryLogic = new CategoryLogic();
            int noOfRows = categoryLogic.SaveCategory(categoryNames);
            //List<Category> categories = categoryLogic.SaveCategory(categoryNames);           

            return noOfRows;
        }
        [WebMethod]
        public int DeleteCategory(int cid)
        {
            //Connecting locally
            CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.DeleteCategory(originalNames);            
            //Category category = categoryLogic.DeleteCategory(originalNames);
            int noOfRows = categoryLogic.DeleteCategory(cid);

            return noOfRows;
        }
        [WebMethod]
        public int UpdateCategory(string originalNames, int originalCid, string newName)
        {
            //Connecting locally
            CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.UpdateCategory(originalCid, originalNames);
            int noOfRows = categoryLogic.UpdateCategory(originalNames, originalCid, newName);
            return noOfRows;
        }
    }
}
