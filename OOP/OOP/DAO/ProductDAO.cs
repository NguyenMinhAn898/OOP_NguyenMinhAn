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
        private static List<Product> listProduct = new List<Product>();

        private Database database = Database.getDatabase;
        public ProductDAO() { }

        public override bool insertTable(Product insertRow)
        {
            listProduct.Add(insertRow);
            return true;
        }

        public override List<Product> findAll()
        {
            return listProduct;
            
        }

        public override List<Product> findAll(string name)
        {
            List<Product> output = new List<Product>();
            foreach(Product product in listProduct)
            {
                if (product.Name.Equals(name))
                {
                    output.Add(product);
                }
            }
            return output;
        }

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

        public override void truncateTable()
        {
            listProduct.Clear();
        }
    }
}
