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
        public CategoryDAO() { }

        private Database database = Database.getDatabase;

        /*
         * Insert one Category in list Category
         * 
         * @Param Category
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Category insertRow)
        {
            int insertId = database.insertTable(insertRow);
            return insertId > 0 ? true : false;
        }

        /*
         * Get all Category
         * 
         * @return List<Category>
         */
        public override List<Category> findAll()
        {
            return database.getListCategory;
        }

        /*
         * Get list Category with Category.Name = name 
         * 
         * @Param name : name search
         * @Return List<Category>
         */
        public override List<Category> findAll(string name)
        {
            //List<Category> output = new List<Category>();
            //foreach(Category category in listCategory)
            //{
            //    if (category.getName.Equals(name))
            //    {
            //        output.Add(category);
            //    }
            //}
            return database.;
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
                if(category.getId == rowUpdate.getId)
                {
                    category.getName = rowUpdate.getName;
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
                if (category.getId == id)
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
