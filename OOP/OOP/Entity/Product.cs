using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }

        public Product() { }

        public Product(int id, String name, int categoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
        }
    }
}
