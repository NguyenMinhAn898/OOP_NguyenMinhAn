using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Table
{
    abstract class BaseDatabase<T>
    {
        public abstract List<T> listTable();
        public abstract int insertTable(T newRow);
        public abstract List<T> selectTable(String name);
        public abstract int updateTable(T updateRow);
        public abstract void truncateTable(T table);
        public abstract bool deleteTable(T row);
    }
}
