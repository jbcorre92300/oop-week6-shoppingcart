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
            List<Article> cart = new List<Article>();
            Article Apple = new Article(0.6M);
            Article Orange = new Article(0.25M);

            cart.Add(Apple);
            cart.Add(Orange);

            Checkout check = new Checkout(cart);
            check.FinalCheckout();

        }
    }
}
