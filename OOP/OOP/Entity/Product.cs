using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Product : BaseRow,IEntity
    {
        private int categoryId;
        public Product() { }

        public Product(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, String name ,int categoryid)
        {
            Id = id;
            Name = name;
            categoryId = categoryid;
        }
        
        public int getCategoryId()
        {
            return categoryId;
        }
        public void setCategoryId(int cateId)
        {
            categoryId = cateId;
        }
    }
}
