using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    interface IDao<T>
    {
        /// <summary>
        /// Insert row in table
        /// </summary>
        /// <param name="insertRow">Object table</param>
        /// <returns>True || False </returns>
        bool insertTable(T insertRow);

        /// <summary>
        /// Find All list
        /// </summary>
        /// <returns></returns>
        List<T> findAll();

        /// <summary>
        /// Find list row table by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<Object> findAllByName(String name);

        /// <summary>
        /// Find a row table by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T findById(int id);

        /// <summary>
        /// Update a row in table
        /// </summary>
        /// <param name="rowUpdate"></param>
        /// <returns></returns>
        T updateTable(T rowUpdate);

        /// <summary>
        /// Delete a row in table
        /// </summary>
        /// <param name="rowDelete"></param>
        /// <returns></returns>
        bool deleteRow(T rowDelete);

        /// <summary>
        /// Truncate table
        /// </summary>
        void truncateTable();
    }
}
