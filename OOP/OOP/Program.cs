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
        private static AccessoryDaoDemo accessoryDaoDemo = new AccessoryDaoDemo();
        private static ProductDaoDemo productDaoDemo = new ProductDaoDemo();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! OOP");
            fetchData();
            Bai7();
            Category();
            Accessory();
            
        }

        public static void Bai7()
        {

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
            Console.WriteLine("+++++ Accessory +++++");
            Console.WriteLine("\n++ Insert : ");
            accessoryDaoDemo.insertTest();

            Console.WriteLine("\n++ Find All : ");
            List<Accessory> listAllAccessory = accessoryDaoDemo.findAllTest();
            accessoryDaoDemo.display(listAllAccessory);

            Console.WriteLine("\n++ Find By name : ");
            List<Accessory> listAccessoryByName = accessoryDaoDemo.findListTest("Phu kien 1");
            accessoryDaoDemo.display(listAccessoryByName);

            Console.WriteLine("\n++ Update Accessory : ");
            Accessory AccessoryUpdate = new Accessory(8, "Trung cu");
            int checkupdate = accessoryDaoDemo.updateTest(AccessoryUpdate);
            if (checkupdate > 0)
            {
                Console.WriteLine("Cap nhap thanh cong id : 8");
            }
            else
            {
                Console.WriteLine("Cap nhap that bai ");
            }

            Console.WriteLine("\n++ Xoa accessory id = 7");
            bool checkDeleteAccessory = accessoryDaoDemo.deleteTest(new Accessory(7, "Phu kien 7"));
            if (checkDeleteAccessory)
            {
                Console.WriteLine("Xoa thanh cong id = 7");
            }
            else
            {
                Console.WriteLine("Fail");
                Console.WriteLine("Xoa tiep bang id");
                if (accessoryDaoDemo.deleteTest(7))
                {
                    Console.WriteLine("Xoas thanh cong");
                }
                else
                {
                    Console.WriteLine("Xoa that bai");
                }
            }

            Console.WriteLine("\n++ Danh sach cuoi cung :");
            accessoryDaoDemo.display(accessoryDaoDemo.findAllTest());
        }

        public static void Product()
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
            if (checkupdate > 0)
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
        public static void fetchData()
        {
            databaseDemo.initDatabase();
        }
        
    }   
}
