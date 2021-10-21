using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;
using OOP.Table;

namespace OOP.Table
{
    class TableCategory : BaseDatabase<Category>
    {
        public override bool deleteTable(Category row)
        {

            return false;
        }

        public override int insertTable(Category newRow)
        {

            return newRow.Id;
        }

        public override List<Category> listTable()
        {
            return new List<Category>();
        }

        public override List<Category> selectTable(string name)
        {
            return new List<Category>();
        }

        public override void truncateTable(Category table)
        {
            
        }

        public override int updateTable(Category updateRow)
        {
            return updateRow.Id;
        }
    }
}
