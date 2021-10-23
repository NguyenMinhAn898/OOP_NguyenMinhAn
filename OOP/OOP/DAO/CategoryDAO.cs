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
        private String TableName = "Category";
        public override string tableName
        {
            get
            {
                return this.TableName;
            }
        }


        public CategoryDAO() { }

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
         * Delete one Category with id category
         * 
         * @Param id
         * @Return Success -> True || Fail -> False
         */
        public bool deleteRow(int id)
        {

            return database.deleteTable(new Category(id));
        }
    }
}
