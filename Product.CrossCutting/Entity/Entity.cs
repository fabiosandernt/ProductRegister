﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.CrossCutting.Entity
{
    public class Entity<T>
    {
        public virtual T Id { get; set; }
    }
}
