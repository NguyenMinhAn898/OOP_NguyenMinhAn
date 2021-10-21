using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Product
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
        public int CategoryId {
            get
            {
                return CategoryId;
            }
            set
            {
                this.CategoryId = value;
            }
        }

    }
}
