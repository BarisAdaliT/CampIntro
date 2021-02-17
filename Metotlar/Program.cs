using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "Elma";
            double Fiyati = 15;
            string Aciklama = "amasya elması";
            
            //classtan bir degişken tanımlamak için "new" eklamn gerekiyor
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyar bakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //foreach (var item in collection) 'var' class belirler (eğer bir yaratıgın bir classta 
            // elamanlar arsı göngü yapacaksen varı o class yapmalısın)
            //'item' bir değişken ne oldugu fark etmez
            //'collection' döndürmek iştedigin dizi 
            //type safe - tip güvenli
            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("--------------------");
                Console.WriteLine(x.Adi + "\n" + x.Fiyati + "\n" + x.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("\n----------Metotlar--------------\n");

            //instance--örnek
            // encapsulation

            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            Console.WriteLine("---------------------------");
            sepetManeger.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManeger.Ekle2("elma", "yeşil elma", 12, 10);
            sepetManeger.Ekle2("karpuz", "diyarbakır kapuzu", 12, 10);
        }
    }
}





//do not repeat yourself = DRY
// Clean Code - Best Practive (dogru uygulama)
