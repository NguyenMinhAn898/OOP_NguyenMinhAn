using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Product : BaseRow
    {
        private int categoryId;
        /// <summary>
        /// Create Constructor
        /// </summary>
        public Product() { }

        /// <summary>
        /// Constructor with 2 param
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Product(int id, String name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Constructor with 3 param
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryid"></param>
        public Product(int id, String name ,int categoryid)
        {
            Id = id;
            Name = name;
            categoryId = categoryid;
        }
        
        /// <summary>
        /// Get id category
        /// </summary>
        /// <returns></returns>
        public int getCategoryId()
        {
            return categoryId;
        }

        /// <summary>
        /// Set id category
        /// </summary>
        /// <param name="cateId"></param>
        public void setCategoryId(int cateId)
        {
            categoryId = cateId;
        }
    }
}
