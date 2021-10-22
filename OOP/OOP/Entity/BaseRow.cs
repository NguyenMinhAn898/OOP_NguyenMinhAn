using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    abstract class BaseRow:IEntity
    {
        public abstract int getId();

        public abstract string getName();

        public abstract void setId(int id);

        public abstract void setName(string name);
    }
}
