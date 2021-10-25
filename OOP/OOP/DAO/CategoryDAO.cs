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

        /// <summary>
        /// Update name table 
        /// </summary>
        public override string tableName
        {
            get
            {
                return this.TableName;
            }
        }

        /// <summary>
        /// Create constructor
        /// </summary>
        public CategoryDAO() { }


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
