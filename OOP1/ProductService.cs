﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductService
    {
        public void Add(Product product) //Product eklemek.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

    }
}
