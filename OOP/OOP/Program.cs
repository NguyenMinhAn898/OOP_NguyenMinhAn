using System;
using OOP.Entity;
using OOP.DAO;
namespace OOP
{
    class Program
    {
        private Category category;
        private CategoryDAO categoryDAO;  
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Category cate = new Category(1, "Hoa qua");
            bool i = categoryDAO.insert(cate);
        }
        
    }   
}
