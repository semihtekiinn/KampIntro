using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {   
        //naming convention (Adlandırma kuralı) - Class'ların ilk harfi büyük olur.
        //syntax - Yazım şekli
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : "+urun.Adi );
            Console.WriteLine("--------------------------------");
        }

        public void Ekle2(string urunAdi, double fiyati, string aciklama,int stokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklediniz : "+urunAdi);
        }
    }
}
