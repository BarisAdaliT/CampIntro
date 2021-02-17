using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılımcı yetiştirme kampı";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "java";
            //array 
            string[] kurslar = new string[] { "yazılımcı yetiştirme kampı", "programlamaya giriş", "java" };

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine("\n---------------------------------\n");
            // kusrlar.length arrayin eleman sayısını verir
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\nfor bitti\n");

            // foreach sadece dizilere uygulanır
            // dizilerde ki her bir eleman için tek tek döner 
            // foreach (var item in collection)
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\nsayfa sonu - footer");
        }
    }
}
