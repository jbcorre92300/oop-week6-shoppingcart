using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace oop_week6_shoppingcart
{
    public class Cart
    {
        public List<Article> shopcart;

        public Cart()
        {
            //Shopcart = shopcart;
        }
        
        public List<Article> Shopcart { get; set; }
        public void FinalCheckout()
        {
            decimal total =0;
            foreach (Article article in shopcart)
            {
                total += article.price;
            }
            Console.WriteLine($"The total checkout is {total} euros");
        }

        public void Addapple()
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
        }
    }
}
