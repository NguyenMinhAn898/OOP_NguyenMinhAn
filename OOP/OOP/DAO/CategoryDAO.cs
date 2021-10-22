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
        public override List<Category> findAllByName(string name)
        {
            return database.getListCategory;
        }

        /*
         * Get a Category by id
         *  
         * @Param id
         * @Return Category
         */
        public override Category findById(int id)
        {
            return null;
        }

        /*
         * Upate table Category
         * 
         * @Param Category
         * @Return Category
         */
        public override Category updateTable(Category rowUpdate)
        {
            return database.updateTable(rowUpdate) > 0 ? rowUpdate : null;
        }

        /*
         * Delete one Category
         * 
         * @Param Category
         * @Return Success -> True || Fail -> False
         */
        public override bool deleteRow(Category rowDelete)
        {
            return database.deleteTable(rowDelete);
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

        /*
         * Truncate Category
         * 
         */
        public override void truncateTable()
        {
            database.truncateTable(new Category());
        }

    }
}
