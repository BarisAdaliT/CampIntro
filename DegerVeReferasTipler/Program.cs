using System;

namespace DegerVeReferasTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = ?? (30) sayi2 = 65
            // 'new' heap te adres tutmak için kullanılır
            //new aslında pointer olarak düşüne bilir
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar2 in tutugu adresi sayilar1 e atıyor bu yüzden sayilar1 artık sayilar2 olarak düşüne bilrisiniz
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ?? (999) sayilar2[0] = 999


            //int,dacimal,double,bool = deger tip
            //array,class,interface=referans tip

        }
    }
}
