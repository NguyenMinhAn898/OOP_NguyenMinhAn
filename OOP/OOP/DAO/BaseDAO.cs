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
        public abstract String tableName { get; }

        /// <summary>
        /// Insert row in table
        /// </summary>
        /// <param name="rowInsert"> new row insert table </param>
        /// <returns>True || false </returns>
        public bool insertTable(T rowInsert)
        {
            return database.insertTable(tableName, rowInsert) > 0 ? true : false;
        }

        /// <summary>
        /// Get all list row in table
        /// </summary>
        /// <returns></returns>
        public List<T> findAll()
        {
            return database.selectTable(tableName).Cast<T>().ToList();
        }

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

        /// <summary>
        /// Delete row in table
        /// </summary>
        /// <param name="rowDelete">a row delete </param>
        /// <returns> Suceess -> true || Fail -> false </returns>
        public bool deleteRow(T rowDelete)
        {
            return database.deleteTable(tableName, rowDelete);
        }

        /// <summary>
        /// Truncate table
        /// </summary>
        public void truncateTable()
        {
            database.truncateTable(tableName);
        }
    }
}
