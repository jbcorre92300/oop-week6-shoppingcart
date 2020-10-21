using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Article apple = new Article();
            Article orange = new Article();

            cart.Addapple();
            cart.Addorange();

            cart.FinalCheckout();




        }
    }
}
