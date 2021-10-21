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

        private static List<Product> listProduct = null;
        private static List<Category> listCategory = null;
        private static List<Accessory> listAccessory = null;

        public static List<Product> getListProduct
        {
            get
            {
                if(listProduct == null)
                    listProduct = new List<Product>();
                return listProduct;
            }
        }
        public static List<Category> getListCategory
        {
            get
            {
                if (listCategory == null)
                    listCategory = new List<Category>();
                return listCategory;
            }
        }
        public static List<Accessory> getListAccessory
        {
            get
            {
                if (listAccessory == null)
                    listAccessory = new List<Accessory>();
                return listAccessory;
            }
        }

        public static int insertTable(String name, object row)
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
         * @return array (Danh sach du lieu tim duoc (success) hoac new list<object> (khong ton tai du lieu) hoac where isempy -> all list)
         */
        public static List<object> selectTable(String name, String where)
        {
            List<object> output = new List<object>();
            if (name.Equals("Category"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    // or using foreach-> add
                    output = listCategory.Cast<object>().ToList();
                }
                else
                {
                    foreach (Category category in listCategory)
                    {
                        if (category.Name.Length > 0 && category.Name.Equals(where))
                        {
                            output.Add((object)category);
                        }
                    }
                }                
            }
            else if (name.Equals("Product"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    output = listProduct.Cast<object>().ToList();
                }
                else
                {
                    foreach (Product product in listProduct)
                    {
                        if (product.Name.Length > 0 && product.Name.Equals(where))
                        {
                            output.Add((object)product);
                        }
                    }
                }
            }
            else if (name.Equals("Accessory"))
            {
                if (String.IsNullOrEmpty(where))
                {
                    output = listAccessory.Cast<object>().ToList();
                }
                else
                {
                    foreach (Accessory accessory in listAccessory)
                    {
                        if (accessory.Name.Length > 0 && accessory.Name.Equals(where))
                        {
                            output.Add((object)accessory);
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Cap nhap mot ban ghi trong danh sach theo name table va object truyen vao
         * 
         * @param name ( name Table can cap nhap)
         * @param row (object table moi)
         * @return int (id cua table duoc cap nhap (success) hoac 0 (fail))
         */
        public static int updateTable(String name, object row)
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
         * Xoa mot ban ghi trong danh sach theo name table va object truyen vao
         * 
         * @param name ( name Table)
         * @param row (object table)
         * @return true (success) or false (fail)
         */
        public static bool deleteTable(String name, object row)
        {
            bool output = false;
            if (name.Equals("Category"))
            {
                Category updateCategory = (Category)row;
                if (updateCategory.Id > 0)
                {
                    foreach (Category category in listCategory)
                    {
                        if (category.Id == updateCategory.Id)
                        {
                            listCategory.Remove(category);
                            output = true;
                        }
                    }
                }
            }
            else if (name.Equals("Product"))
            {
                Product updateProduct = (Product)row;
                if (updateProduct.Id > 0)
                {
                    foreach (Product product in listProduct)
                    {
                        if (product.Id == updateProduct.Id)
                        {
                            listProduct.Remove(product);
                            output = true;
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
        public static void truncateTable(String name)
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
    }
}
