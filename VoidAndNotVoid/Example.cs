using System;
using System.Collections.Generic;
using System.Text;

namespace VoidAndNotVoid
{
    class Example
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            sayi1 = 84;
            sayi2 = 75;
            
            Console.WriteLine(sayi1 + sayi2);

        }
    }
}
