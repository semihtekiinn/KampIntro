using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 100, TcKimlikNo = "1234567910", Adi = "Semih", Soyadi = "Tekin", Yas = 24, Meslegi = "Yazılımcı" };
            Musteri musteri2 = new Musteri() { Id = 101, TcKimlikNo = "1234567911", Adi = "Enes", Soyadi = "Yıldırım", Yas = 23, Meslegi = "Subay" };
            Musteri musteri3 = new Musteri() { Id = 102, TcKimlikNo = "1234567912", Adi = "Kadir", Soyadi = "Kesecek", Yas = 25, Meslegi = "Mühendis" };


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine(" ");

            musteriManager.Listele(musteriler);

            Console.WriteLine(" ");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);




        }
    }
}
