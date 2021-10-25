using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;
using OOP.Entity;

namespace OOP.DAO
{
    class ProductDAO : BaseDAO<Product>
    {
        private String ProductName = "Product";

        /// <summary>
        /// Override tableName
        /// </summary>
        public override string tableName => this.ProductName;

        /// <summary>
        /// Create constructor
        /// </summary>
        public ProductDAO() { }
    }
}
