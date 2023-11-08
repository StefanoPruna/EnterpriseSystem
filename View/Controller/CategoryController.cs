using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Controller
{
    public class CategoryController
    {
        public List<Category> ShowCategory()
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            List<Category> categories = categoryLogic.ShowCategory();

            return categories;
        }
        public int SaveCategory(string categoryNames)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            int noOfRows = categoryLogic.SaveCategory(categoryNames);
            //List<Category> categories = categoryLogic.SaveCategory(categoryNames);

            return noOfRows;
        }
        public int DeleteCategory(int cid)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.DeleteCategory(originalNames);            
            //Category category = categoryLogic.DeleteCategory(originalNames);
            int noOfRows = categoryLogic.DeleteCategory(cid);

            return noOfRows;
        }
        public int UpdateCategory(string originalNames, int originalCid, string newName, int newCid)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            //categoryLogic.UpdateCategory(originalCid, originalNames);
            int noOfRows = categoryLogic.UpdateCategory(originalNames, originalCid, newName, newCid);
            return noOfRows;
        }
    }
}
