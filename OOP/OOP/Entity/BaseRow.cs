﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    abstract class BaseRow
    {
        abstract protected int Id { get; set; }
        abstract protected String Name { get; set; }
    }
}
