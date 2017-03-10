using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers
{
    public class ProductCatalog
    {
        static Dictionary<string,Product> products = new Dictionary<string, Product>();

        static ProductCatalog()
        {
            products.Add("redDress",    new Product("1001.1", "Red Dress",   100.0));
            products.Add("greenDress",  new Product("1001.2", "Green Dress", 100.0));
            products.Add("blueDress",   new Product("1001.3", "Blue Dress",  100.0));
            products.Add("yellowDress", new Product("1001.4", "Yellow Dress",  100.0));
            products.Add("whiteSocks",  new Product("2001.1", "White Socks", 10.0));
            products.Add("redSocks",    new Product("2001.2", "Red Socks",   10.0));
            products.Add("blackSocks", new Product("2001.3", "Black Socks", 10.0));
            products.Add("whitePants", new Product("3001.1", "White Pants", 50.0));
            products.Add("redPants", new Product("3001.2", "Red Pants", 50.0));
            products.Add("blackPants", new Product("3001.3", "Black Pants", 50.0));
        }

        public static Product GetProduct(string name)
        {
            return products[name];
        }
    }
}
