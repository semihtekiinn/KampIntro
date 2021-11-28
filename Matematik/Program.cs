using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 9);
            dortIslem.Topla(15, 98);

            dortIslem.Cikar(14, 6);

            dortIslem.Carp(7, 3);

            dortIslem.Bol(15,3);
        }
    }
}
