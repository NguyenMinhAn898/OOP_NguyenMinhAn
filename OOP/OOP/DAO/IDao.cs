﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    interface IDao<T>
    {
        bool insertTable(T insertRow);
        List<T> findAll();
        List<T> findAllByName(String name);
        T findById(int id);
        T updateTable(T rowUpdate);
        bool deleteRow(T rowDelete);
        void truncateTable();
    }
}
