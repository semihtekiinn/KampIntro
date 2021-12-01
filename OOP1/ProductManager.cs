using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   //ProductManeger ProductService gibi sonuna Manager Service gibi isimlendirmeler görürsek
    //anlarız ki ürünle ilgili operasyonlar var bu classın içinde.
    //O operasyonlar ekleme silme güncelleme listeleme arama filtreleme vs gibi operasyonlar içerir.
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
