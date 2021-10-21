using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;
using OOP.Entity;

namespace OOP.Demo
{
    class CategoryDaoDemo
    {
        private CategoryDAO categoryDAO = new CategoryDAO();
        public void insertTest()
        {
            Category newCategory = new Category(12, "Cay canh");
            if (categoryDAO.insert(newCategory))
            {
                Console.WriteLine("Them moi thanh cong");
            }
            else
            {
                Console.WriteLine("Them danh muc that bai");
            }

        }
        public List<Category> findAllTest()
        {
            return categoryDAO.findListCategory();

        }

        public List<Category> findListTest(String name)
        {
            return categoryDAO.findListCategory(name);
        }
        public int updateTest(Category category)
        {
            Category categoryUpdate = categoryDAO.udpateCategory(category);
            if (categoryUpdate != null)
                return categoryUpdate.Id;
            return 0;
        }
        public bool deleteTest(Category category)
        {
            if (category.Id <= 0)
                return false;
            return categoryDAO.deleteCategory(category);
        }
        public void truncateTest()
        {

        }

        public void display(List<Category> listCategory)
        {
            Console.WriteLine("Danh sach Danh muc (display in categoryDaoDemo) :");
            foreach(Category category in listCategory)
            {
                Console.WriteLine(" -Id : " + category.Id + " , Name : " + category.Name);
            }
            Console.WriteLine("");
        }
        public void display(Category category)
        {
            Console.WriteLine("Danh muc : ");
            Console.WriteLine(" -Id : " + category.Id + " , Name : " + category.Name +"\n");
        }
    }
}
