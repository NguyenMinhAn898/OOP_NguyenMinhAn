using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Category
    {
        public int Id { 
            get 
            {
                return Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public String Name {
            get
            {
                return Name;
            }
            set
            {
                this.Name = value;
            }
        }

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
