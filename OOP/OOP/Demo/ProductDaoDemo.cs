using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;

namespace OOP.Demo
{
    class ProductDaoDemo
    {
        private static ProductDAO productDAO = new ProductDAO();

        public void insertTest()
        {
            Product newProduct = new Product(12, "Hoa dong tien",12);
            if (productDAO.insertTable(newProduct))
            {
                Console.WriteLine("Them moi san pham thanh cong");
            }
            else
            {
                Console.WriteLine("Them danh muc that bai");
            }
        }
        public List<Product> findAllTest()
        {
            return productDAO.findAll();
        }

        public List<Product> findListTest(String name)
        {
            return productDAO.findAll(name);
        }
        public int updateTest(Product Product)
        {
            Product ProductUpdate = productDAO.updateTable(Product);
            if (ProductUpdate != null)
                return ProductUpdate.getId();
            return 0;
        }
        public bool deleteTest(Product Product)
        {
            if (Product.getId() <= 0)
                return false;
            return productDAO.deleteRow(Product);
        }
        public void truncateTest()
        {
            productDAO.truncateTable();
        }

        public void display(List<Product> listProduct)
        {
            Console.WriteLine("+ Danh sach San pham : ");
            foreach (Product Product in listProduct)
            {
                Console.WriteLine("  -Id : " + Product.getId() + " , Name : " + Product.getName());
            }
            Console.WriteLine("");
        }
        public void display(Product Product)
        {
            Console.WriteLine("+ San pham : ");
            Console.WriteLine("  -Id : " + Product.getId() + " , Name : " + Product.getName() + "\n");
        }

    }
}
