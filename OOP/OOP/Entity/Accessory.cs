using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Entity;

namespace OOP.Entity
{
    class Accessory : BaseRow
    {
        public Accessory() { }

        public Accessory(int id)
        {
            Id = id;
        }
        public Accessory(int id, String name)
        {
            Id = id;
            Name = name;
        }        
    }
}
