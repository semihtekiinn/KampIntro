using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   //Class'lar ikiye ayrılır. İçerisinde 'özellik' barındıran class'lar
    //ve içerisinde 'operasyon(metot)'barındıran classlar olmak üzere ikiye ayrılır.


    //Özellik içeren bir class 
    class Product
    {
        public int Id { get; set; }
        //Hangi kategoriye ait olduğu
        public int CategoryId { get; set; }
        //Ürün ismi
        public string ProductName { get; set; }
        //Ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //Stok Adedi
        public int UnitsInStock { get; set; }

    }

    //CRUD Operasyonları - Create Read Update Delete 
}
