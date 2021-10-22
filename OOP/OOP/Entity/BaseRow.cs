using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    abstract class BaseRow:IEntity
    {
        public int Id {get; set;}
        public string Name { get; set; }
    }
}
