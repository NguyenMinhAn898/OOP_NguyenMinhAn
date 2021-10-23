using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;

namespace OOP.DAO
{
    abstract class BaseDAO<T> : IDao<T>
    {
        protected Database database = Database.getDatabase;
        public abstract String tableName { get;} 

        public bool insertTable(T rowInsert)
        {            
            return database.insertTable(tableName, rowInsert) > 0 ? true : false;
        }
        public abstract List<T> findAll();

        /*
         * Get list row 
         * 
         * @Param name : name search
         * @Return List<BaseRow>
         */
        public List<Object> findAllByName(String name)
        {
            return database.selectTable(tableName, name);
        }

        /*
         * Get a row with id row 
         * 
         * @Param id : id row
         * @Return a object is row
         */
        public T findById(int id)
        {
            return (T)database.findTableById(tableName, id);
        }

        /*
         * Upate table 
         * 
         * @Param Ttable
         * @Return row update
         */
        public T updateTable(T rowUpdate)
        {
            return database.updateTable(tableName, rowUpdate) > 0 ? rowUpdate : default(T);
        }
        public bool deleteRow(T rowDelete)
        {
            return database.deleteTable(tableName, rowDelete);
        }

        /*
         * Truncate table
         * 
         */
        public void truncateTable()
        {
            database.truncateTable(tableName);
        }
    }
}
