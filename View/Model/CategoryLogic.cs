using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryLogic
    {
        public List<Category> ShowCategory()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> categories = categoryDAO.ShowCategory();
            return categories;
        }
        public int SaveCategory(string categoryNames)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            int noOfRows = categoryDAO.SaveCategory(categoryNames);
            return noOfRows;
        }
        public int DeleteCategory(int cid)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            int noOfRows = categoryDAO.DeleteCategory(cid);
            return noOfRows;
        }

        public int UpdateCategory(string originalNames, int originalCid, string newName, int newCid)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            int noOfRows = categoryDAO.UpdateCategory(originalNames, originalCid, newName, newCid);
            return noOfRows;
        }
    }
}
