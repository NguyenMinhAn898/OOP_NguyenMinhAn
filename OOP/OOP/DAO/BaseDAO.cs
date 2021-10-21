using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    abstract class BaseDAO<T>
    {
        private Database database = Database.getDatabase;
        public abstract bool insertTable(T insertRow);
        public abstract List<T> findAll();
        public abstract List<T> findAll(String name);
        public abstract T updateTable(T rowUpdate);
        public abstract bool deleteRow(T rowDelete);
        public abstract void truncateTable(T table);
    }
}
