using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            BMevzuat bMevzuat = new BMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            bMevzuat.Degerlendir();
            bMevzuat.Kaydet();
        }
    }

    abstract class MevzuatBase
    {
        
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }

    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatı değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatı değerlendirildi.");
        }
    } 

}
