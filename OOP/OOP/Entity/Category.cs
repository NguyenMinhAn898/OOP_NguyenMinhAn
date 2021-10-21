using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Category(int id, String name)
        {
            Id = id;
            Name = name;
        }
        public Category()
        {
        }
    }
}
