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

        /// <summary>
        /// Override string tableName
        /// </summary>
        public override string tableName => this.AccessoryName;

        /// <summary>
        /// Create constructor
        /// </summary>
        public AccessoryDAO() { }
    }
}
