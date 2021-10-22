using System;
using OOP.Entity;
using OOP.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class CategoryDAO : BaseDAO<Category>
    {
        private CategoryDAO() { }

        private static CategoryDAO categoryDAO;

        public static CategoryDAO getCategoryDAO
        {
            get
            {
                if (categoryDAO == null)
                    categoryDAO = new CategoryDAO();
                return categoryDAO;
            }
            
        }

        private static List<Category> listCategory = new List<Category>();

        /*
         * Get list Category
         * 
         * @return List<Category>
         */
        public static List<Category> getListCategory()
        {
            return listCategory;
        }

        /*
         * Insert one Category in list Category
         * 
         * @Param Category
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Category insertRow)
        {
            listCategory.Add(insertRow);
            return true;
        }

        /*
         * Get all Category
         * 
         * @return List<Category>
         */
        public override List<Category> findAll()
        {
            return listCategory;
        }

        /*
         * Get list Category with Category.Name = name 
         * 
         * @Param name : name search
         * @Return List<Category>
         */
        public override List<Category> findAll(string name)
        {
            List<Category> output = new List<Category>();
            foreach(Category category in listCategory)
            {
                if (category.Name.Equals(name))
                {
                    output.Add(category);
                }
            }
            return output;
        }

        /*
         * Upate table Category
         * 
         * @Param Category
         * @Return Category
         */
        public override Category updateTable(Category rowUpdate)
        {
            bool checkUpdate = false;
            foreach(Category category in listCategory)
            {
                if(category.Id == rowUpdate.Id)
                {
                    category.Name = rowUpdate.Name;
                    checkUpdate = true;
                }
            }
            return checkUpdate ? rowUpdate : new Category();
        }

        /*
         * Delete one Category
         * 
         * @Param Category
         * @Return Success -> True || Fail -> False
         */
        public override bool deleteRow(Category rowDelete)
        {
            return listCategory.Remove(rowDelete);
        }

        /*
         * Delete one Category with id category
         * 
         * @Param id
         * @Return Success -> True || Fail -> False
         */
        public bool deleteRow(int id)
        {
            foreach (Category category in listCategory)
            {
                if (category.Id == id)
                {
                    listCategory.Remove(category);
                    return true;
                }
            }
            return false;
        }

        /*
         * Truncate Category
         * 
         */
        public override void truncateTable()
        {
            listCategory.Clear();
        }
    }
}
