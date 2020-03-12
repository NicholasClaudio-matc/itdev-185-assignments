using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class PriceList<TProduct, TPrice>
    {
        public TProduct product;
        public TPrice price;

        public PriceList (TProduct theProduct, TPrice thePrice)
        {
            product = theProduct;
            price = thePrice;
        }

        public void Print()
        {
            Console.WriteLine("");

            Console.WriteLine("Product: " + product.ToString());
            Console.WriteLine("Price: " + price.ToString());
        }
    
    }
}
