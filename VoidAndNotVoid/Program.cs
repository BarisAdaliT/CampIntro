using System;

namespace VoidAndNotVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 65;
            int sayi2 = 51;
            
            Example example = new Example();

            example.Topla2(sayi1, sayi2);

            Console.WriteLine(sayi1 + sayi2);
 
            int sonuc = example.Topla(sayi1, sayi2);
            Console.WriteLine(sonuc);

            
        }
    }
}
