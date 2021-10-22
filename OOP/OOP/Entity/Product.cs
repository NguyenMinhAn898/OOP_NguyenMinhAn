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
        private int Id;
        private String Name;
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

        public override int getId()
        {
            return Id;
        }

        public override string getName()
        {
            return Name;
        }

        public override void setId(int id)
        {
            Id = id;   
        }

        public override void setName(string name)
        {
            Name = name;
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
