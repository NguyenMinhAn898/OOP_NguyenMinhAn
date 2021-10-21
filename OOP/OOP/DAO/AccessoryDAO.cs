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
        public AccessoryDAO() { }

        private static List<Accessory> listAccessory = new List<Accessory>();

        private Database database = Database.getDatabase;

        public override bool insertTable(Accessory insertRow)
        {
            listAccessory.Add(insertRow);
            return true;            
        }

        public override List<Accessory> findAll()
        {
            return listAccessory;
        }

        public override List<Accessory> findAll(string name)
        {
            List<Accessory> output = new List<Accessory>();
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Name.Equals(name))
                {
                    output.Add(accessory);
                }
            }
            return output;
        }       

        public override Accessory updateTable(Accessory rowUpdate)
        {
            bool checkUpdate = false;
            foreach(Accessory accessory in listAccessory)
            {
                if(accessory.Id == rowUpdate.Id)
                {
                    accessory.Name = rowUpdate.Name;
                    checkUpdate = true;
                }
            }
            return checkUpdate ? rowUpdate : new Accessory();
        }

        public override bool deleteRow(Accessory rowDelete)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Id == rowDelete.Id)
                {
                    listAccessory.Remove(accessory);
                    return true;
                }
            }
            return false;
        }

        public override void truncateTable()
        {
            listAccessory.Clear();
        }

    }
}
