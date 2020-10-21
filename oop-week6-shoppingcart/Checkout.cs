using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace oop_week6_shoppingcart
{
    public class Checkout
    {
        public List<Article> Shopcart { get; set; }

        public Checkout(List<Article> cart)
        {
            Shopcart = cart;
        }
        
        
        public void FinalCheckout()
        {
            decimal total =0;
            foreach (Article article in Shopcart)
            {
                total += article.Price;
            }
            Console.WriteLine($"The total checkout is {total} euros");
        }

        /*public void Addapple()
        {
            Article apple = new Article();
            apple.Price = 0.6M;
            shopcart.Add(apple);
        }

        public void Addorange()
        {
            Article orange = new Article();
            orange.Price = 0.25M;
            shopcart.Add(orange);
        }*/
    }
}
