using System;
using OOP.Entity;
using OOP.DAO;
using OOP.Demo;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        private static DatabaseDemo databaseDemo = new DatabaseDemo();
        private static CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! OOP");
            fetchData();
            Bai7();
            Category();
            
        }

        public static void Bai7()
        {
            // Câp nhap category
            String name = "Category";
            Object CategoryUpdate = new Category(5, "Trai cay");

            if (databaseDemo.updateTableTest(name, CategoryUpdate))
            {
                Console.WriteLine("Cap nhap thanh cong ! success");
            }
            else
            {
                Console.WriteLine("Update fail ");
            }            
        }

        public static void Category()
        {
            Console.WriteLine("+++++ Category +++++");
            Console.WriteLine("\n++ Insert : ");
            categoryDaoDemo.insertTest();

            Console.WriteLine("\n++ Find All : ");
            List<Category> listAllCategory = categoryDaoDemo.findAllTest();
            categoryDaoDemo.display(listAllCategory);

            Console.WriteLine("\n++ Find By name : ");
            List<Category> listCategoryByName = categoryDaoDemo.findListTest("Cay canh");
            categoryDaoDemo.display(listCategoryByName);

            Console.WriteLine("\n++ Update Categroy : ");
            Category categoryUpdate = new Category(8, "Trung cu");
            int checkupdate = categoryDaoDemo.updateTest(categoryUpdate);
            if(checkupdate > 0)
            {
                Console.WriteLine("Cap nhap thanh cong id : 8");
            }
            else
            {
                Console.WriteLine("Cap nhap that bai ");
            }

            Console.WriteLine("\n++ Xoa danh muc id = 7");
            bool checkDeleteCategory = categoryDaoDemo.deleteTest(new Category(7, "Quan trong phai dung object"));
            if (checkDeleteCategory)
            {
                Console.WriteLine("Xoa thanh cong id = 7");
            }
            else
            {
                Console.WriteLine("Fail");
                Console.WriteLine("Xoa tiep bang id");
                if (categoryDaoDemo.deleteTest(7))
                {
                    Console.WriteLine("Xoas thanh cong");
                }
                else
                {
                    Console.WriteLine("Xoa that bai");
                }
            }

            Console.WriteLine("\n++ Danh sach cuoi cung :");
            categoryDaoDemo.display(categoryDaoDemo.findAllTest());

        }

        public static void Accessory()
        {

        }
        public static void fetchData()
        {
            databaseDemo.initDatabase();
        }
        
    }   
}
