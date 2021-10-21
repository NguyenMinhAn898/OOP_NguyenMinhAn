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
        public Database database = Database.getDatabase;        
        public DatabaseDemo() { }
        public void insertTableTest() 
        {
        }
        public void selectTableTest() { }
        public bool updateTableTest(String name, Object rowUpdate )
        {
            int checkUpdate = Database.updateTable(name, rowUpdate);           

            return checkUpdate > 0 ? true : false;
        }
        public void deleteTableTest() { }
        public void truncateTableTest() { }
        public void initDatabase() 
        {
            for(int i = 1; i<= 10; i++)
            {
                Object newCategory = new Category(i, "Hoa qua " + i);
                Object newPoduct = new Product(i, "Tao tau " + i, i);
                Object newAccessory = new Accessory(i, "Phu kien " + i);
                database.insertTable("Category", newCategory);
                database.insertTable("Product", newPoduct);
                database.insertTable("Accessory", newAccessory);
            }
        } 
        public void printTableTest() 
        {
            List<Product> listProduct = database.getListProduct;
            Console.WriteLine("Danh sach Product : ");
            foreach(Product product in listProduct)
            {
                Console.WriteLine("- ID : " + product.Id + ", Name : " + product.Name);
            }

            Console.WriteLine("Danh sach Category : ");
            List<Category> listCategory = database.getListCategory;
            foreach(Category category in listCategory)
            {
                Console.WriteLine("- ID : " + category.Id + ", Name : " + category.Name);
            }

            Console.WriteLine("Danh sach Ass : ");
            List<Accessory> listAccessory = database.getListAccessory;
            foreach (Accessory accessory in listAccessory)
            {
                Console.WriteLine("- ID : " + accessory.Id + ", Name : " + accessory.Name);
            }
        }        
    }
}
