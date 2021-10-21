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
                if(listProduct == null)
                    listProduct = new List<Product>();
                return listProduct;
            }
        }
        public List<Category> getListCategory
        {
            get
            {
                if (listCategory == null)
                    listCategory = new List<Category>();
                return listCategory;
            }
        }
        public List<Accessory> getListAccessory
        {
            get
            {
                if (listAccessory == null)
                    listAccessory = new List<Accessory>();
                return listAccessory;
            }
        }

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
                        if (category.Name.Length > 0 && category.Name.Equals(where))
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
                        if (product.Name.Length > 0 && product.Name.Equals(where))
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
                        if (accessory.Name.Length > 0 && accessory.Name.Equals(where))
                        {
                            output.Add((Object)accessory);
                        }
                    }
                }
            }
            return output;
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
                if(updateCategory.Id > 0)
                {
                    foreach (Category category in listCategory)
                    {
                        if (category.Id == updateCategory.Id)
                        {
                            output = updateCategory.Id;
                            category.Name = updateCategory.Name;
                        }
                    }
                }               
            }
            else if (name.Equals("Product"))
            {
                Product updateProduct = (Product)row;
                if(updateProduct.Id > 0)
                {
                    foreach (Product product in listProduct)
                    {
                        if(product.Id == updateProduct.Id)
                        {
                            output = updateProduct.Id;
                            product.Name = updateProduct.Name;
                            product.CategoryId = updateProduct.CategoryId;
                        }
                    }
                }
                
            }
            else if (name.Equals("Accessory"))
            {
                Accessory updateAccessory = (Accessory)row;
                if (updateAccessory.Id > 0)
                {
                    foreach (Accessory accessory in listAccessory)
                    {
                        if (accessory.Id == updateAccessory.Id)
                        {
                            output = updateAccessory.Id;
                            accessory.Name = updateAccessory.Name;
                        }
                    }
                }
            }
            return output;
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
                if (deleteCategory.Id > 0)
                {
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
            }
            else if (name.Equals("Product"))
            {
                Product deleteProduct = (Product)row;
                if (deleteProduct.Id > 0)
                {
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

            }
            else if (name.Equals("Accessory"))
            {
                Accessory updateAccessory = (Accessory)row;
                if (updateAccessory.Id > 0)
                {
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
            }
            return output;
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

        public Object findById(String name, int id)
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
    }
}
