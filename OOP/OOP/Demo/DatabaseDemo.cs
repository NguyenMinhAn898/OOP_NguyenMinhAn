using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;
using OOP.Entity;

namespace OOP.Demo
{
    class DatabaseDemo
    {
        public void insertTableTest() 
        {
        }
        public void selectTableTest() { }
        public static bool updateTableTest(String name, Object rowUpdate )
        {
            int checkUpdate = Database.updateTable(name, rowUpdate);           

            return checkUpdate > 0 ? true : false;
        }
        public void deleteTableTest() { }
        public void truncateTableTest() { }
        public static void initDatabase() 
        {
            for(int i = 1; i<= 10; i++)
            {
                Object newCategory = new Category(i, "Hoa qua " + i);
                Object newPoduct = new Product(i, "Tao tau " + i, i);
                Object newAccessory = new Accessory(i, "Phu kien " + i);
                Database.insertTable("Category", newCategory);
                Database.insertTable("Product", newPoduct);
                Database.insertTable("Accessory", newAccessory);
            }
        } 
        public static void printTableTest() 
        {
            List<Product> listProduct = Database.getListProduct;
            Console.WriteLine("Danh sach Product : ");
            foreach(Product product in listProduct)
            {
                Console.WriteLine("- ID : " + product.Id + ", Name : " + product.Name);
            }

            Console.WriteLine("Danh sach Category : ");
            List<Category> listCategory = Database.getListCategory;
            foreach(Category category in listCategory)
            {
                Console.WriteLine("- ID : " + category.Id + ", Name : " + category.Name);
            }
        }        
    }
}
