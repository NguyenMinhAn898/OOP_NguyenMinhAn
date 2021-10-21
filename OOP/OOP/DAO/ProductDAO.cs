using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class ProductDAO
    {
        private Database database = Database.getDatabase;
        private String ProductName = "Product";
        public ProductDAO() { }

        public bool inserProduct(Product product)
        {
            return database.insertTable(product) > 0 ? true : false;
        }
        public List<Product> findAllProduct()
        {
            return database.getListProduct;
        }
        public Product findProductById(int id)
        {
            return (Product)database.findTableById(ProductName, id);
        }
        public Product updateProduct(Product product)
        {
            int id = database.updateTable(ProductName, product);
            return id > 0 ? product : new Product();
        }

        public void truncateProduct()
        {
            database.truncateTable(ProductName);
        }
    }
}
