using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";
            string kurs5 = "Python";


            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Temel Kurs", "Java", "C#", "Python","C++"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                Console.WriteLine("-----");
            }

            Console.WriteLine("----------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }   
    }
}
