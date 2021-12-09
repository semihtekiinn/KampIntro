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
    // bunlar entity'dir yani özellik property class'ıdır. Onların içinde operasyonlar olmaz. )
    //Miras - Inheritance - class GercekMusteri :Musteri


    class GercekMusteri :Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


    }
}
