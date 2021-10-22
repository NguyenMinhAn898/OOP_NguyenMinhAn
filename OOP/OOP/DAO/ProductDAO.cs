using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;

namespace OOP.DAO
{
    class ProductDAO : BaseDAO<Product>,IDao<Product>
    {
        public ProductDAO() { }

        public static Database database = Database.getDatabase;
        
        /*
         * Insert one Product in list Product
         * 
         * @Param Product
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Product insertRow)
        {
            return database.insertTable(insertRow) > 0 ? true : false;
        }

        /*
         * Get all product
         * 
         * @return List<Product>
         */
        public override List<Product> findAll()
        {
            return database.getListProduct;            
        }

        /*
         * Get list Product with Product.Name = name 
         * 
         * @Param name : name search
         * @Return List<Product>
         */
        public override List<Product> findAll(String name)
        {
            return null;
        }

        /*
         * Upate table Product
         * 
         * @Param Product
         * @Return Product
         */
        public override Product updateTable(Product rowUpdate)
        {
            return database.updateTable(rowUpdate) > 0 ? rowUpdate : null;

        }

        /*
         * Delete one Product
         * 
         * @Param Product
         * @Return Success -> True || Fail -> False
         */
        public override bool deleteRow(Product rowDelete)
        {
            return database.deleteTable(rowDelete);
        }

        /*
         * Truncate Product
         * 
         */
        public override void truncateTable()
        {
            database.truncateTable(new Product());
        }
    }
}
