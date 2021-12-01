using System;

namespace GenericsUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(12,"Twelve");
            myDictionary.Add(50, "Fifty");

        }
    }
}
