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

        private static List<Product> listProduct = new List<Product>() ;
        private static List<Category> listCategory  = new List<Category>();
        private static List<Accessory> listAccessory = new List<Accessory>() ;

        public List<Product> getListProduct
        {
            get
            {
                return listProduct;
            }
        }
        public List<Category> getListCategory
        {
            get
            {
                return listCategory;
            }
        }
        public List<Accessory> getListAccessory
        {
            get
            {
                return listAccessory;
            }
        }

        // code chưa clearn cần clean hơn nữa
        public int insertTable(String name, Object row)
        {
            if (name.Equals("Category"))
            {
                Category category = (Category)row;
                listCategory.Add(category);
                return listCategory.Count;
            } else if (name.Equals("Product"))
            {
                Product product = (Product)row;
                listProduct.Add(product);
                return listProduct.Count;
;           } else if (name.Equals("Accessory"))
            {
                Accessory newAccessory = (Accessory)row;
                listAccessory.Add(newAccessory);
                return listAccessory.Count;
            }
            return 0;
        }
        public int insertTable(Category category)
        {
            listCategory.Add(category);
            return listCategory.Count;
        }
        public int insertTable(Product product)
        {
            listProduct.Add(product);
            return listProduct.Count;
        }
        public int insertTable(Accessory accessory)
        {
            listAccessory.Add(accessory);
            return listAccessory.Count;
        }

        /**
         * Tim kiem danh sach du lieu them ten cua bang va ten can tim
         * 
         * @param name ( name Table can cap nhap)
         * @param where (ten can tim trong du lieu)
         * @return array (Danh sach du lieu tim duoc (success) hoac new list<Object> (khong ton tai du lieu) hoac where isempy -> all list)
         */
        public List<Object> selectTable(String name, String where)
        {
            List<Object> output = new List<Object>();
            if (name.Equals("Category"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    // or using foreach-> add
                    output = listCategory.Cast<Object>().ToList();
                }
                else
                {
                    foreach (Category category in listCategory)
                    {
                        if (category.getName().Length > 0 && category.getName().Equals(where))
                        {
                            output.Add((Object)category);
                        }
                    }
                }                
            }
            else if (name.Equals("Product"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    output = listProduct.Cast<Object>().ToList();
                }
                else
                {
                    foreach (Product product in listProduct)
                    {
                        if (product.getName().Length > 0 && product.getName().Equals(where))
                        {
                            output.Add((Object)product);
                        }
                    }
                }
            }
            else if (name.Equals("Accessory"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    output = listAccessory.Cast<Object>().ToList();
                }
                else
                {
                    foreach (Accessory accessory in listAccessory)
                    {
                        if (accessory.getName().Length > 0 && accessory.getName().Equals(where))
                        {
                            output.Add((Object)accessory);
                        }
                    }
                }
            }
            return output;
        }

        public List<Category> selectTable(String name)
        {
            return listCategory;
        }

       

        /**
         * Cap nhap mot ban ghi trong danh sach theo name table va Object truyen vao
         * 
         * @param name ( name Table can cap nhap)
         * @param row (Object table moi)
         * @return int (id cua table duoc cap nhap (success) hoac 0 (fail))
         */
        public int updateTable(String name, Object row)
        {
            int output = 0;
            if (name.Equals("Category"))
            {
                Category updateCategory = (Category)row;
                foreach (Category category in listCategory)
                {
                    if (category.getId() == updateCategory.getId())
                    {
                        output = updateCategory.getId();
                        category.setName(updateCategory.getName());
                    }
                }
            }
            else if (name.Equals("Product"))
            {
                Product updateProduct = (Product)row;                
                foreach (Product product in listProduct)
                {
                    if(product.getId() == updateProduct.getId())
                    {
                        output = updateProduct.getId();
                        product.setName(updateProduct.getName());
                        product.setCategoryId(updateProduct.getCategoryId());
                    }
                }
            }
            else if (name.Equals("Accessory"))
            {
                Accessory updateAccessory = (Accessory)row;
                foreach (Accessory accessory in listAccessory)
                {
                    if (accessory.getId() == updateAccessory.getId())
                    {
                        output = updateAccessory.getId();
                        accessory.setName(updateAccessory.getName());
                    }
                }
            }
            return output;
        }

        public int updateTable(Category categoryUpdate)
        {
            foreach(Category category in listCategory)
            {
                if(category.getId() == categoryUpdate.getId())
                {
                    category.setName(categoryUpdate.getName());
                    return categoryUpdate.getId();
                }
            }
            return 0;
        }

        public int updateTable(Product productUpdate)
        {
            foreach (Product product in listProduct)
            {
                if (product.getId() == productUpdate.getId())
                {
                    product.setName(productUpdate.getName());
                    return productUpdate.getId();
                }
            }
            return 0;
        }

        public int updateTable(Accessory accessoryUpdate)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.getId() == accessoryUpdate.getId())
                {
                    accessory.setName(accessoryUpdate.getName());
                    return accessoryUpdate.getId();
                }
            }
            return 0;
        }

        /**
         * Xoa mot ban ghi trong danh sach theo name table va Object truyen vao
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
                    if (category.getId() == deleteCategory.getId())
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
                    if (product.getId() == deleteProduct.getId())
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
                    if (accessory.getId() == updateAccessory.getId())
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
            foreach(Category category in listCategory)
            {
                if(category.getId() == categoryDelete.getId())
                {
                    return listCategory.Remove(categoryDelete) ? true : false;
                }
            }
            return false;
        }

        public bool deleteTable(Product productDelete)
        {
            foreach (Product product in listProduct)
            {
                if (product.getId() == productDelete.getId())
                {
                    return listProduct.Remove(productDelete) ? true : false;                    
                }
            }
            return false;
        }

        public bool deleteTable(Accessory accessoryDelete)
        {
            foreach (Accessory accessory in listAccessory)
            {
                if (accessory.getId() == accessoryDelete.getId())
                {
                    return listAccessory.Remove(accessoryDelete) ? true : false;
                }
            }
            return false;
        }
        /**
         * Xoa toan bo danh sach theo name table
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

        public void  truncateTable(Category category)
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
                    if (category.getId() == id)
                    {
                        output = category;
                    }
                }                
            }
            else if (name.Equals("Product"))
            {
                foreach (Product product in listProduct)
                {
                    if (product.getId() == id)
                    {
                        output = product;
                    }
                }                
            }
            else if (name.Equals("Accessory"))
            {                
                foreach (Accessory accessory in listAccessory)
                {
                    if (accessory.getId() == id)
                    {
                        output = accessory;
                    }
                }                
            }
            return output;
        }

        public Category findTableById(Category input)
        {
            foreach(Category category in listCategory)
            {
                if(category.getId() == input.getId())
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
                if (product.getId() == input.getId())
                {
                    return product;
                }
            }
            return null;
        }
        public Accessory findTableById(Accessory input)
        {
            foreach(Accessory accessory in listAccessory)
            {
                if(accessory.getId() == input.getId())
                {
                    return accessory;
                }
            }
            return null;
        }

    }
}
