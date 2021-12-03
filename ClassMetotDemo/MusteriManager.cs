using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" isimli müşteri sisteme eklendi." );
        }

        

        public void Listele(Musteri[] musteriler )
        {

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Tc Kimlik No: " + musteri.TcKimlikNo);
                Console.WriteLine("Müşteri Adı: " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyadi);
                Console.WriteLine("Müşteri Yaşı: " + musteri.Yas);
                Console.WriteLine("Müşteri Mesleği: " + musteri.Meslegi);
                Console.WriteLine("-------------------------------");

            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " isimli müşteri sistemden silindi.");
        }

    }
}
