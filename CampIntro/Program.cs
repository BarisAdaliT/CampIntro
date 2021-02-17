using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself - kendini tekrarlama
            // kategoriEtiketi deger tutucu (takma isim)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            //bool degişkeni false yada true degerini tutar
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            Console.WriteLine("---------------");


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kulanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("Kategori");

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
