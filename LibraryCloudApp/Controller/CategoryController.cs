using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CategoryController
    {
        public List<Category> ShowCategory()
        {
            //Connecting locally
            //CategoryLogic categoryLogic = new CategoryLogic();
            //List<Category> categories = categoryLogic.ShowCategory();

            //Connecting via Cloud App
            ServiceReferenceCategory.WebServiceCategoryasmxSoapClient soapClient = new ServiceReferenceCategory.WebServiceCategoryasmxSoapClient();
            ServiceReferenceCategory.Category[] categoryArray = soapClient.ShowCategory();

            List<Category> categories = new List<Category>();

            foreach(ServiceReferenceCategory.Category category in categoryArray)
            {
                Category category2 = new Category();
                category2.Cid = category.Cid;
                category2.CategoryName = category.CategoryName;
                categories.Add(category2);
            }

            return categories;
        }
        public int SaveCategory(string categoryNames)
        {
            //Connecting locally
            //CategoryLogic categoryLogic = new CategoryLogic();
            //int noOfRows = categoryLogic.SaveCategory(categoryNames);
            //List<Category> categories = categoryLogic.SaveCategory(categoryNames);           

            //Connecting via Cloud App
            ServiceReferenceCategory.WebServiceCategoryasmxSoapClient soapClient = new ServiceReferenceCategory.WebServiceCategoryasmxSoapClient(); 
            int noOfRows = soapClient.SaveCategory(categoryNames);

            return noOfRows;
        }
        public int DeleteCategory(int cid)
        {
            //Connecting locally
            //CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.DeleteCategory(originalNames);            
            //Category category = categoryLogic.DeleteCategory(originalNames);
            //int noOfRows = categoryLogic.DeleteCategory(cid);

            //Connecting via Cloud App
            ServiceReferenceCategory.WebServiceCategoryasmxSoapClient soapClient = new ServiceReferenceCategory.WebServiceCategoryasmxSoapClient();
            int noOfRows = soapClient.DeleteCategory(cid);

            return noOfRows;
        }
        public int UpdateCategory(string originalNames, int originalCid, string newName)
        {
            //Connecting locally
            //CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.UpdateCategory(originalCid, originalNames);
            //int noOfRows = categoryLogic.UpdateCategory(originalNames, originalCid, newName);

            //Connecting via Cloud App
            ServiceReferenceCategory.WebServiceCategoryasmxSoapClient soapClient = new ServiceReferenceCategory.WebServiceCategoryasmxSoapClient();
            int noOfRows = soapClient.UpdateCategory(originalNames, originalCid, newName);  

            return noOfRows;
        }
    }
}
