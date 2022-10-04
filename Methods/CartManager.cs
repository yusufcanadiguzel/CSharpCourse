using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün sepete eklendi. Ürün bilgisi : " + product.Name);
        }
    }
}
