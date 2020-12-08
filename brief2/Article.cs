using System;
using System.Collections.Generic;

namespace brief2
{
    public class Article
    {
        public int refNum;
        public string name;
        public float price;
        public float sellPrice;
        public List<Article> stock = new List<Article>();

        public Article()
        {
          
        }


        public Article(int refNum, string name, float price, float sellPrice)
        {
            this.refNum = refNum;
            this.name = name;
            this.price = price;
            this.sellPrice = sellPrice;

            if (sellPrice < price)
            {
                throw new ArgumentNullException("sell price can not be less than buy price");
            }
        }

        public void introduce()
        {
            Console.WriteLine("this " + name + " has a price of " + sellPrice);

        }
      
    }
}
