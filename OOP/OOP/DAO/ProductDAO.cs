using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;

namespace OOP.DAO
{
    class ProductDAO : BaseDAO<Product>
    {
        private ProductDAO() { }

        private static ProductDAO productDAO ;

        public static ProductDAO getProductDAO
        {
            get
            {
                if (productDAO == null)
                    productDAO = new ProductDAO();
                return productDAO;
            }
        }

        private static List<Product> listProduct = new List<Product>();

        /*
         * Get list product
         * 
         * @return List<Product>
         */
        public List<Product> getListProduct()
        {
            return listProduct;
        }
        
        /*
         * Insert one Product in list Product
         * 
         * @Param Product
         * @return Success -> True || Fail -> False
         */
        public override bool insertTable(Product insertRow)
        {
            listProduct.Add(insertRow);
            return true;
        }

        /*
         * Get all product
         * 
         * @return List<Product>
         */
        public override List<Product> findAll()
        {
            return listProduct;            
        }

        /*
         * Get list Product with Product.Name = name 
         * 
         * @Param name : name search
         * @Return List<Product>
         */
        public override List<Product> findAll(String name)
        {
            List<Product> output = new List<Product>();
            foreach(Product product in listProduct)
            {
                if (product.getName.Equals(name))
                {
                    output.Add(product);
                }
            }
            return output;
        }

        /*
         * Upate table Product
         * 
         * @Param Product
         * @Return Product
         */
        public override Product updateTable(Product rowUpdate)
        {
            bool checkUpdate = false;
            foreach (Product product in listProduct)
            {
                if (product.Id == rowUpdate.Id)
                {
                    product.Name = rowUpdate.Name;
                    checkUpdate = true;
                }
            }
            return checkUpdate ? rowUpdate : new Product();

        }

        /*
         * Delete one Product
         * 
         * @Param Product
         * @Return Success -> True || Fail -> False
         */
        public override bool deleteRow(Product rowDelete)
        {
            foreach (Product product in listProduct)
            {
                if (product.Id == rowDelete.Id)
                {
                    listProduct.Remove(product);
                    return true;
                }
            }
            return false;
        }

        /*
         * Truncate Product
         * 
         */
        public override void truncateTable()
        {
            listProduct.Clear();
        }
    }
}
