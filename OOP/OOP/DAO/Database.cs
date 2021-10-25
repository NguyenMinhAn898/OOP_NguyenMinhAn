using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class Database
    {
        private static Database instance = null;
        private Database() { }
        public static Database getDatabase
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }

        private static List<Product> listProduct = new List<Product>();
        private static List<Category> listCategory = new List<Category>();
        private static List<Accessory> listAccessory = new List<Accessory>();

        /// <summary>
        ///  Get list Product
        /// </summary>
        public List<Product> getListProduct
        {
            get
            {
                return listProduct;
            }
        }

        /// <summary>
        /// Get list Category
        /// </summary>
        public List<Category> getListCategory
        {
            get
            {
                return listCategory;
            }
        }

        /// <summary>
        /// Get list Accessory
        /// </summary>
        public List<Accessory> getListAccessory
        {
            get
            {
                return listAccessory;
            }
        }

        /**
         * Insert row in list
         * 
         * @param name : string name table
         * @param row : object colum table
         * @return id : id of object insert || 0
         */
        public int insertTable(String name, Object row)
        {
            if (name.Equals("Category"))
            {
                Category newCategory = (Category)row;
                listCategory.Add(newCategory);
                return newCategory.Id;
            }
            else if (name.Equals("Product"))
            {
                Product newProduct = (Product)row;
                listProduct.Add(newProduct);
                return newProduct.Id;
                ;
            }
            else if (name.Equals("Accessory"))
            {
                Accessory newAccessory = (Accessory)row;
                listAccessory.Add(newAccessory);
                return newAccessory.Id;
            }
            return 0;
        }

        /// <summary>
        /// Insert one row in Table Category
        /// </summary>
        /// <param name="newCategory">object Category insert</param>
        /// <returns>id new row</returns>
        public int insertTable(Category newCategory)
        {
            listCategory.Add(newCategory);
            return newCategory.Id;
        }

        /// <summary>
        /// Insert on row in table Product
        /// </summary>
        /// <param name="newProduct">object product is new product </param>
        /// <returns></returns>
        public int insertTable(Product newProduct)
        {
            listProduct.Add(newProduct);
            return newProduct.Id;
        }

        /// <summary>
        /// Insert one row in Accessory
        /// </summary>
        /// <param name="newAccessory"></param>
        /// <returns></returns>
        public int insertTable(Accessory newAccessory)
        {
            listAccessory.Add(newAccessory);
            return newAccessory.Id;
        }

        /**
         * Get list row in table
         * 
         * @param name ( name Table)
         * @param where (name select)
         * @return List<Object>
         */
        public List<Object> selectTable(String name, String where = null)
        {
            if (name.Equals("Category"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    return listCategory.Cast<Object>().ToList();
                }
                return selectTableCategory(where);
            }
            else if (name.Equals("Product"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    return listProduct.Cast<Object>().ToList();
                }
                return selectTableProduct(where); 
            }
            else if (name.Equals("Accessory"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    return listAccessory.Cast<Object>().ToList();
                }
                return selectTableAccessory(where);
            }
            return new List<Object>();
        }

        /// <summary>
        /// Select List Row in table Category
        /// </summary>
        /// <param name="where"> String name select </param>
        /// <returns></returns>
        private List<Object> selectTableCategory(String where)
        {
            List<Object> output = new List<Object>();
            
            foreach (Category category in listCategory)
            {
                if (category.Name.Length > 0 && category.Name.Equals(where))
                {
                    output.Add((Object)category);
                }
            }
            return output;
        }

        /// <summary>
        /// Select list row in table Product
        /// </summary>
        /// <param name="where">String name search </param>
        /// <returns></returns>
        private List<Object> selectTableProduct(String where)
        {
            List<Object> output = new List<Object>();
            foreach (Product product in listProduct)
            {
                if (product.Name.Length > 0 && product.Name.Equals(where))
                {
                    output.Add((Object)product);
                }
            }
            return output;
        }

        /// <summary>
        /// Select list row in table Accessory
        /// </summary>
        /// <param name="where">Name search</param>
        /// <returns></returns>
        private List<Object> selectTableAccessory(String where)
        {
            List<Object> output = new List<Object>();
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Name.Length > 0 && accessory.Name.Equals(where))
                {
                    output.Add((Object)accessory);
                }
            }
            return output;
        }

        /**
         * Update row table 
         * 
         * @param name : Table name 
         * @param row  : Object table update
         * @return ouput : id row update 
         */
        public int updateTable(String name, Object row)
        {
            int output = 0;
            if (name.Equals("Category"))
            {
                Category updateCategory = (Category)row;
                foreach (Category category in listCategory)
                {
                    if (category.Id == updateCategory.Id)
                    {
                        output = updateCategory.Id;
                        category.Name = updateCategory.Name;
                    }
                }
            }
            else if (name.Equals("Product"))
            {
                Product updateProduct = (Product)row;
                foreach (Product product in listProduct)
                {
                    if (product.Id == updateProduct.Id)
                    {
                        output = updateProduct.Id;
                        product.Name = updateProduct.Name;
                        product.setCategoryId(updateProduct.getCategoryId());
                    }
                }
            }
            else if (name.Equals("Accessory"))
            {
                Accessory updateAccessory = (Accessory)row;
                foreach (Accessory accessory in listAccessory)
                {
                    if (accessory.Id == updateAccessory.Id)
                    {
                        output = updateAccessory.Id;
                        accessory.Name = updateAccessory.Name;
                    }
                }
            }
            return output;
        }

        public int updateTable(Category categoryUpdate)
        {
            foreach (Category category in listCategory)
            {
                if (category.Id == categoryUpdate.Id)
                {
                    category.Name = categoryUpdate.Name;
                    return categoryUpdate.Id;
                }
            }
            return 0;
        }

        public int updateTable(Product productUpdate)
        {
            foreach (Product product in listProduct)
            {
                if (product.Id == productUpdate.Id)
                {
                    product.Name = productUpdate.Name;
                    return productUpdate.Id;
                }
            }
            return 0;
        }

        public int updateTable(Accessory accessoryUpdate)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Id == accessoryUpdate.Id)
                {
                    accessory.Name = accessoryUpdate.Name;
                    return accessoryUpdate.Id;
                }
            }
            return 0;
        }

        /**
         * Delete row in table
         * 
         * @param name ( name Table)
         * @param row (Object table)
         * @return true (success) or false (fail)
         */
        public bool deleteTable(String name, Object row)
        {
            bool output = false;
            if (name.Equals("Category"))
            {
                Category deleteCategory = (Category)row;
                foreach (Category category in listCategory)
                {
                    if (category.Id == deleteCategory.Id)
                    {
                        listCategory.Remove(category);
                        output = true;
                        break; // đang lỗi khi remove xong quay lại list lỗi collection-was-modified-enumeration-operation-may-not-execute
                    }
                }

            }
            else if (name.Equals("Product"))
            {
                Product deleteProduct = (Product)row;
                foreach (Product product in listProduct)
                {
                    if (product.Id == deleteProduct.Id)
                    {
                        listProduct.Remove(product);
                        output = true;
                        break;
                    }
                }

            }
            else if (name.Equals("Accessory"))
            {
                Accessory updateAccessory = (Accessory)row;
                foreach (Accessory accessory in listAccessory)
                {
                    if (accessory.Id == updateAccessory.Id)
                    {
                        listAccessory.Remove(accessory);
                        output = true;
                        break;
                    }
                }
            }
            return output;
        }

        public bool deleteTable(Category categoryDelete)
        {
            foreach (Category category in listCategory)
            {
                if (category.Id == categoryDelete.Id)
                {
                    return listCategory.Remove(category) ? true : false;
                }
            }
            return false;
        }

        public bool deleteTable(Product productDelete)
        {
            foreach (Product product in listProduct)
            {
                if (product.Id == productDelete.Id)
                {
                    return listProduct.Remove(product) ? true : false;
                }
            }
            return false;
        }

        public bool deleteTable(Accessory accessoryDelete)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Id == accessoryDelete.Id)
                {
                    return listAccessory.Remove(accessory) ? true : false;
                }
            }
            return false;
        }

        /**
         * Truncate table
         * 
         * @param name ( name Table)
         * @return 
         */
        public void truncateTable(String name)
        {
            if (name.Equals("Category"))
            {
                listCategory.Clear();
            }
            else if (name.Equals("Product"))
            {
                listProduct.Clear();
            }
            else if (name.Equals("Accessory"))
            {
                listAccessory.Clear();
            }
        }

        public void truncateTable(Category category)
        {
            listCategory.Clear();
        }
        public void truncateTable(Product product)
        {
            listProduct.Clear();
        }
        public void truncateTable(Accessory accessory)
        {
            listAccessory.Clear();
        }

        /**
         * Get object in name object and id 
         * 
         * @param name ( name Table) and id (id row in table)
         * @return Object
         */
        public Object findTableById(String name, int id)
        {
            Object output = new Object();
            if (name.Equals("Category"))
            {
                foreach (Category category in listCategory)
                {
                    if (category.Id == id)
                    {
                        output = category;
                    }
                }
            }
            else if (name.Equals("Product"))
            {
                foreach (Product product in listProduct)
                {
                    if (product.Id == id)
                    {
                        output = product;
                    }
                }
            }
            else if (name.Equals("Accessory"))
            {
                foreach (Accessory accessory in listAccessory)
                {
                    if (accessory.Id == id)
                    {
                        output = accessory;
                    }
                }
            }
            return output;
        }

        public Category findTableById(Category input)
        {
            foreach (Category category in listCategory)
            {
                if (category.Id == input.Id)
                {
                    return category;
                }
            }
            return null;
        }
        public Product findTableById(Product input)
        {
            foreach (Product product in listProduct)
            {
                if (product.Id == input.Id)
                {
                    return product;
                }
            }
            return null;
        }
        public Accessory findTableById(Accessory input)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.Id == input.Id)
                {
                    return accessory;
                }
            }
            return null;
        }

    }
}
