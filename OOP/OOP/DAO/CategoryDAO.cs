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

        private static List<Category> listCategory = new List<Category>();

        private Database database = Database.getDatabase;

        public override bool insertTable(Category insertRow)
        {
            listCategory.Add(insertRow);
            return true;
        }

        public override List<Category> findAll()
        {
            return listCategory;
        }

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

        public override bool deleteRow(Category rowDelete)
        {
            return listCategory.Remove(rowDelete);
        }
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

        public override void truncateTable()
        {
            listCategory.Clear();
        }
    }
}
