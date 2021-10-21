using System;
using OOP.Entity;
using OOP.DAO;
using OOP.Demo;

namespace OOP
{
    class Program
    {
        private static DatabaseDemo databaseDemo = new DatabaseDemo();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! OOP");
            fetchData();
            Bai7();

            disPlayAll();   
        }

        public static void Bai7()
        {
            // Câp nhap category
            String name = "Category";
            Object CategoryUpdate = new Category(5, "Trai cay");

            if (databaseDemo.updateTableTest(name, CategoryUpdate))
            {
                Console.WriteLine("Cập nhập thành công");
            }
            else
            {
                Console.WriteLine("Cập nhập thất bại");
            }            
        }

        public static void disPlayAll()
        {
            databaseDemo.printTableTest();
        }

        public static void fetchData()
        {
            databaseDemo.initDatabase();
        }
        
    }   
}
