using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Kavun";
            urun3.Fiyati = 50;
            urun3.Aciklama = "Bal gibi kavun";

            Urun urun4 = new Urun();
            urun4.Adi = "Muz";
            urun4.Fiyati = 15;
            urun4.Aciklama = "Yerli muz";

            Urun urun5 = new Urun();
            urun5.Adi = "Şeftali";
            urun5.Fiyati = 30;
            urun5.Aciklama = "Tüysüz şeftali";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4,urun5};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+" : "+urun.Fiyati+" lira.");
            }

            Console.WriteLine("---------------Metotlar----------------");

            //instance - Örnek oluşturmak
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            sepetManager.Ekle(urun5);

            Console.WriteLine("--------------------------------------");

            sepetManager.Ekle2("Kivi",15,"Yeşil kivi",10);

        }
    }
}
