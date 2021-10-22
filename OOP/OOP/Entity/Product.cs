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
        override protected int Id { get; set; }
        override protected String Name { get; set; }
        protected int CategoryId { get; set; }

        public Product() { }
        public Product(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public int getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public int getCategory()
        {
            return CategoryId;
        }
    }
}
