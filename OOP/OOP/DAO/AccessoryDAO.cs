using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;

namespace OOP.DAO
{
    class AccessoryDAO : BaseDAO<Accessory>
    {
        private Database database = Database.getDatabase;
        public override bool insertTable(Accessory insertRow)
        {
            throw new NotImplementedException();
        }

        public override bool deleteRow(Accessory rowDelete)
        {
            throw new NotImplementedException();
        }

        public override List<Accessory> findAll()
        {
            throw new NotImplementedException();
        }

        public override List<Accessory> findAll(string name)
        {
            throw new NotImplementedException();
        }       

        public override void truncateTable(Accessory table)
        {
            throw new NotImplementedException();
        }

        public override Accessory updateTable(Accessory rowUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
