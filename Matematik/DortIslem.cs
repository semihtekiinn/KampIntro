using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int cikartma = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikartma);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpma);
        }

        public void Bol(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolme);
        }
    }
}
