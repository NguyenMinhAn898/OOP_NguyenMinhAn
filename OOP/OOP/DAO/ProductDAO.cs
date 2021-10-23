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
        public override string tableName => this.ProductName;

        public ProductDAO() { }

        /*
         * Get all product`
         * 
         * @return List<Product>
         */
        public override List<Product> findAll()
        {
            return database.getListProduct;            
        }
    }
}
