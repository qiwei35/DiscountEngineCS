﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers
{
    public class Product
    {
        public Product(string sku, string name, double price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }

        public string Sku { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
