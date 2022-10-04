using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " isimli ürün eklendi.\n");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " isimli ürün güncellendi.\n");
        }
    }
}
