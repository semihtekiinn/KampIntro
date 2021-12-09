using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    // Individual - Biireysel (Gerçek) Müşteri
    // Coorparate - Tüzel müşteri
    // Implementation - Uygulama 
    // Entity - Varlık ( Classlarda Musteri, Employee, Customer, Urun, Product gibi isimlendirme varsa
    // bunlar entity'dir yani özellik property class'ıdır. )

    //Miras - Inheritance - class TuzelMusteri:Musteri 

    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }


    }
}
