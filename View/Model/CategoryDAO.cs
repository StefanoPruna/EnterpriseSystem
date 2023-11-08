using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.DataSetCategoryTableAdapters;
using static Model.DataSetCategory;

namespace Model
{
    public class CategoryDAO
    {
        public List<Category> ShowCategory()
        {
            TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();
            DataSetCategory.TabCategoryDataTable tabCategories = tabCategoryTableAdapter.ShowCategory();

            int dataCount = tabCategories.Count;
            if (dataCount != 0)
            {
                List<Category> categories = new List<Category>();

                foreach (DataRow row in tabCategories)
                {
                    int cid = Convert.ToInt32(row["CID"]);
                    string categoryName = row["CategoryName"].ToString();

                    Category category = new Category();

                    category.Cid = cid;
                    category.CategoryName = categoryName;

                    categories.Add(category);
                }
                return categories;
            }
            else
                return null;
        }
        public int SaveCategory(string categoryNames)
        {
            //int cid = Convert.ToInt32(categoryId);
            TabCategoryTableAdapter categoryAdapter = new TabCategoryTableAdapter();

            int noOfRows = categoryAdapter.SaveCategory(categoryNames);

            return noOfRows;
        }

        public int DeleteCategory(int cid)
        {
            TabCategoryTableAdapter categoryAdapter = new TabCategoryTableAdapter();
            int noOfRows = categoryAdapter.DeleteCategory(cid);
            return noOfRows;
        }

        public int UpdateCategory(string originalNames, int originalCid, string newName, int newCid)
        {
            TabCategoryTableAdapter categoryAdapter = new TabCategoryTableAdapter();
            int noOfRows = categoryAdapter.UpdateCategory(originalNames, originalCid, newName, newCid);
            return noOfRows;
        }
    }
}
