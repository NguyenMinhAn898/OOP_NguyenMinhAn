using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;
using OOP.Entity;

namespace OOP.Table
{
    class TableAccessory : BaseDatabase<Accessory>
    {
        public override bool deleteTable(Accessory row)
        {
            throw new NotImplementedException();
        }

        public override int insertTable(Accessory newRow)
        {
            throw new NotImplementedException();
        }

        public override List<Accessory> listTable()
        {
            throw new NotImplementedException();
        }

        public override List<Accessory> selectTable(string name)
        {
            throw new NotImplementedException();
        }

        public override void truncateTable(Accessory table)
        {
            throw new NotImplementedException();
        }

        public override int updateTable(Accessory updateRow)
        {
            throw new NotImplementedException();
        }
    }
}
