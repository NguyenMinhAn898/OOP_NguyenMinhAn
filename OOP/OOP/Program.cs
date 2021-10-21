using System;
using OOP.Entity;
using OOP.DAO;
using OOP.Demo;

namespace OOP
{
    class Program
    {
        private Category category;
        private CategoryDAO categoryDAO;  
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String name = "Category";
            Object CategoryUpdate = new Category(5, "Trai cay");
            DatabaseDemo.initDatabase();

            if (DatabaseDemo.updateTableTest(name, CategoryUpdate)) {
                Console.WriteLine("Cập nhập thành công");
            }
            else {
                Console.WriteLine("Cập nhập thất bại");
            }

            DatabaseDemo.printTableTest();
        }
        
    }   
}
