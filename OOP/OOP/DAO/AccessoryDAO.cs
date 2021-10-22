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

        private Database database = Database.getDatabase;

        /*
         * Insert one Accessory in list Accessory
         * 
         * @Param Accessory
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Accessory insertRow)
        {
            return database.insertTable(insertRow) > 0 ? true : false;
        }

        /*
         * Get all Accessory
         * 
         * @return List<Accessory>
         */
        public override List<Accessory> findAll()
        {
            return database.getListAccessory;
        }

        /*
         * Get list Accessory with Accessory.Name = name 
         * 
         * @Param name : name search
         * @Return List<Accessory>
         */
        public override List<Accessory> findAllByName(string name)
        {
            //return database.selectTable("Accessory", name);
            return null;
        }

        public override Accessory findById(int id)
        {
            return null;
        }

        /*
         * Upate table Accessory
         * 
         * @Param Accessory
         * @Return Accessory
         */
        public override Accessory updateTable(Accessory rowUpdate)
        {
            return database.updateTable(rowUpdate) > 0 ? rowUpdate : null;
        }

        /*
        * Delete one Accessory
        * 
        * @Param Accessory
        * @Return Success -> True || Fail -> False
        */
        public override bool deleteRow(Accessory rowDelete)
        {
            return database.deleteTable(rowDelete);
        }

        public bool deleteRow(int id)
        {
            return database.deleteTable(new Accessory(id));
        }

        /*
         * Truncate Accessory
         * 
         */
        public override void truncateTable()
        {
            database.truncateTable(new Accessory());
        }

    }
}
