using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;

namespace OOP.Entity
{
    class Accessory : BaseRow, IEntity
    {
        private int Id;
        private String Name;

        public Accessory() { }

        public Accessory(int id, String name)
        {
            Id = id;
            Name = name;
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
    }
}
