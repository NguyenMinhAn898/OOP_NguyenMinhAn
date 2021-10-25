using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Category : BaseRow
    {
        /// <summary>
        /// Create Constructor
        /// </summary>
        public Category() { }

        /// <summary>
        /// Constructor with a param
        /// </summary>
        public Category(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Constructor with 2 param
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Category(int id, String name)
        {
            Id = id;
            Name = name;
        }        
    }
}
