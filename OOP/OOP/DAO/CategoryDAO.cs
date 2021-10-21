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
        private String CategoryName = "Category";
        private static Database database = Database.getDatabase;
        public bool insert(Category category)
        {
            int checkInsert = database.insertTable(CategoryName, category);
            return checkInsert > 0 ? true : false;
        }
    }
}
