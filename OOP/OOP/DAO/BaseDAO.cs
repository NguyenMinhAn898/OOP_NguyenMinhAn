using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    abstract class BaseDAO<T>:IDao<T>
    {
        public abstract bool insertTable(T insertRow);
        public abstract List<T> findAll();
        public abstract List<T> findAllByName(string name);
        public abstract T findById(int id);
        public abstract T updateTable(T rowUpdate);
        public abstract bool deleteRow(T rowDelete);
        public abstract void truncateTable();

    }
}
