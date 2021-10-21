using System;
using OOP.Entity;
using OOP.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class CategoryDAO
    {
        public CategoryDAO() { }
        private String CategoryName = "Category";
        private static Database database = Database.getDatabase;
        public bool insert(Category category)
        {
            int checkInsert = database.insertTable(CategoryName, category);
            return checkInsert > 0 ? true : false;
        }
        public List<Category> findListCategory(String name = null)
        {
            List<Category> output = new List<Category>();
            if (String.IsNullOrEmpty(name))
            {
                output = database.getListCategory;
            }
            else
            {
                output = database.selectTable(CategoryName, name).Cast<Category>().ToList();
            }
            return output;
        }
        public Category udpateCategory(Category category)
        {
            int checkUpdate = database.updateTable(CategoryName, category);
            if (checkUpdate > 0)
                return category;
            return new Category();
        }
        public bool deleteCategory(Category category)
        {
            return database.deleteTable(CategoryName, category);
        }

        public Category findCategoryById(int id)
        {
            if (id <= 0)
                return new Category();
            return (Category)database.findById(CategoryName, id);
        }
    }
}
