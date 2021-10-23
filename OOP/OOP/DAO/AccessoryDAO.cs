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
        private  String AccessoryName = "Accessory";
        public override string tableName => this.AccessoryName;

        public AccessoryDAO() { }

        /*
         * Get all Accessory
         * 
         * @return List<Accessory>
         */
        public override List<Accessory> findAll()
        {
            return database.getListAccessory;
        }
    }
}
