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
        private AccessoryDAO() { }

        private static AccessoryDAO accessoryDAO;

        public AccessoryDAO getAccessoryDAO
        {
            get
            {
                if (accessoryDAO == null)
                    accessoryDAO = new AccessoryDAO();
                return accessoryDAO;
            }
        }

        private static List<Accessory> listAccessory = new List<Accessory>();

        /*
         * Get list Accessory
         * 
         * @return List<Accessory>
         */
        public List<Accessory> getListAccessory()
        {
            return listAccessory;
        }

        /*
         * Insert one Accessory in list Accessory
         * 
         * @Param Accessory
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Accessory insertRow)
        {
            listAccessory.Add(insertRow);
            return true;            
        }

        /*
         * Get all Accessory
         * 
         * @return List<Accessory>
         */
        public override List<Accessory> findAll()
        {
            return listAccessory;
        }

        /*
         * Get list Accessory with Accessory.Name = name 
         * 
         * @Param name : name search
         * @Return List<Accessory>
         */
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

        /*
         * Upate table Accessory
         * 
         * @Param Accessory
         * @Return Accessory
         */
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

        /*
        * Delete one Accessory
        * 
        * @Param Accessory
        * @Return Success -> True || Fail -> False
        */
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

        /*
         * Truncate Accessory
         * 
         */
        public override void truncateTable()
        {
            listAccessory.Clear();
        }

    }
}
