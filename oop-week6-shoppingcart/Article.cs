﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace oop_week6_shoppingcart
{
    public class Article
    {
        public decimal Price { get; set; }
        public Article(decimal price)
        {
            Price = price;
        }
       
    }
}
