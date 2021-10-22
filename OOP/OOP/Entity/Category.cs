using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Category:BaseRow,IEntity
    {
        override protected int Id { get; set; }
        override protected string Name { get; set; }

        public Category()
        {
        }
        public Category(int id, String name)
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
    }
}
