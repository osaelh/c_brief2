using System.Collections.Generic;
using System.Linq;

namespace brief2
{
    public class Stock
    {
        public List<Article> article { get; set; }
        public Stock()
        {
            article = new List<Article>();
        }

        public void add(int refNum,string name, int price, int sellPrice)
        {
            var product = new Article(refNum, name, price, sellPrice);
            article.Add(product);
        }

        public void delete(int index)
        {
            article.RemoveAt(index);
        }

        public bool isExist(string name)
        {
            return article.Exists(x => x.name == name);
        } 

        public void modify(int refNum, string name, int price, int sellPrice, int index)
        {
            article[index].refNum = refNum;
            article[index].name = name;
            article[index].price = price;
            article[index].sellPrice = sellPrice;

        }



    }
}
