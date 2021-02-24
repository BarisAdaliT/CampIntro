using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // eğer bir sayı uzerinde işlem yapmıyacaksak onlar sadece bir ifade olarak kalıcaksa srting/long yapmak daha iyi sonuçlar vericektir
            //tüzel ile bireyi bir birine karıştırma 
            // eger bir nesnede bir degeri kulanmak zorunda gibi gözüküyorsan o nesneye aid degilmiş gibi duruyorsa orada soyutlama hatası yapıyorsun
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.MusteriNo = "1";
            musteri1.Adi = "Barış";
            musteri1.Soyadi = "Türkmen";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2";
            musteri2.SirketAdi = "Çorumlular";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            

        }
    }
}
