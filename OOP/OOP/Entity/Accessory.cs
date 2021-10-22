using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;

namespace OOP.Entity
{
    class Accessory:BaseRow,IEntity
    {
        override protected int Id { get; set; }
        override protected String Name { get; set; }

        public Accessory() { }
        public Accessory(int id, String name)
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
