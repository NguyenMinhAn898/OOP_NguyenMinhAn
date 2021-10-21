using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    abstract class BaseRow
    {
        public abstract int Id { get; set; }
        public abstract String Name { get; set; }
    }
}
