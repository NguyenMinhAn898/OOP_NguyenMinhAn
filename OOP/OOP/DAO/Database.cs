using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    public class Database
    {
        private static Database instance = null;
        private Database() { }
        public static Database GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }
        private static List<Product> listProduct;
        public static List<Product> productTable
        {
            get
            {
                if(listProduct == null)
                {
                    listProduct = new List<Product>();
                }
                return listProduct;
            }
        }
        //List<Category> categoryTable();
        //List<Accessory> accesoryTable();

        //int insertTable(T name,T row) ;
        //List<T> selectTable(T name, T where);
        //int updateTable(T name, T row);
        //bool deleteTable(T name, T row);
        //void truncateTable(T name);

        //bool updateById(int id, T row);
    }
}
