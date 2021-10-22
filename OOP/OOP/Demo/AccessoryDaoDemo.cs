using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.DAO;
using OOP.Entity;

namespace OOP.Demo
{
    class AccessoryDaoDemo
    {
        private static AccessoryDAO accessoryDAO = AccessoryDAO.getAccessoryDAO;
        public void insertTest()
        {
            Accessory newAccessory = new Accessory(13, "Phu kien hoa dong tien");
            if (accessoryDAO.insertTable(newAccessory))
            {
                Console.WriteLine("Them moi accessory thanh cong");
            }
            else
            {
                Console.WriteLine("Them accessory that bai");
            }
        }
        public List<Accessory> findAllTest()
        {
            return accessoryDAO.findAll();
        }

        public List<Accessory> findListTest(String name)
        {
            return accessoryDAO.findAll(name);
        }
        public int updateTest(Accessory Accessory)
        {
            Accessory AccessoryUpdate = accessoryDAO.updateTable(Accessory);
            if (AccessoryUpdate != null)
                return AccessoryUpdate.Id;
            return 0;
        }
        public bool deleteTest(Accessory Accessory)
        {
            if (Accessory.Id <= 0)
                return false;
            return accessoryDAO.deleteRow(Accessory);
        }
        public void truncateTest()
        {
            accessoryDAO.truncateTable();
        }

        public void display(List<Accessory> listAccessory)
        {
            Console.WriteLine("+ Danh sach Accessory : ");
            foreach (Accessory Accessory in listAccessory)
            {
                Console.WriteLine("  -Id : " + Accessory.Id + " , Name : " + Accessory.Name);
            }
            Console.WriteLine("");
        }
        public void display(Accessory Accessory)
        {
            Console.WriteLine("+ Accessory : ");
            Console.WriteLine("  -Id : " + Accessory.Id + " , Name : " + Accessory.Name + "\n");
        }
    }
}
