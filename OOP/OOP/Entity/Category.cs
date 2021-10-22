using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Category : BaseRow
    {
        public Category() { }

        public Category(int id)
        {
            Id = id;
        }

        public Category(int id, String name)
        {
            Id = id;
            Name = name;
        }        
    }
}
