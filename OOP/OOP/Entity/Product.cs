using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Product:BaseRow
    {
        public override int Id { get; set; }
        public override String Name { get; set; }
        public int CategoryId { get; set; }

        public Product() { }
        public Product(int id, String name)
        {
            Id = id;
            Name = name;
        }
        public Product(int id, String name, int categoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
        }
    }
}
