using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //her bir Managerin calışması
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("--------------------------------");
            
            //IKrediManager türünden hesaplanma
            
            //bunlar bankada çalısan elemanın erkanında ki butonlar


            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            ihtiyacKrediManager1.Hesapla();
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            tasitKrediManager1.Hesapla();
            IKrediManager konutKrediManager1 = new KonutKrediManager();
            konutKrediManager1.Hesapla();

            

            

            Console.WriteLine("---------------------------------");

            //yukarıda bastıgın butona göre kredi türü hesaplama  () içine gönderilen veriye göre olucak burada 
            //hepsi için teker teker deneme amaçlı yapıldı
            ILogerService databaseLoggerService = new DateBaseLoggerManager();
            databaseLoggerService.Log();
            ILogerService filebaseLogerService = new FileBaseLoggerManager();
            filebaseLogerService.Log();
            Console.WriteLine("-------------------------------------------");

            BasruruManager basruruManager = new BasruruManager();
            basruruManager.BasvuruYap(ihtiyacKrediManager1, databaseLoggerService);
            basruruManager.BasvuruYap(ihtiyacKrediManager1, filebaseLogerService);

            //basruruManager.BasvuruYap(tasitKrediManager1); 
            //basruruManager.BasvuruYap(konutKrediManager1);

            Console.WriteLine("-----------------------------------");

            //eger krediye karar veremedim hangi kredide ne kadar ödeyecegini merek ediyorsun  tıklanan butonlara göre karsılıgını veren karsılastırma yapısı {} içine gelen veri 
            // yazılacak 
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1, tasitKrediManager1, konutKrediManager1};

            basruruManager.KrediOnBiligilendirmesiYap(krediler);

            BasruruManager basruruManager1 = new BasruruManager();

            Console.WriteLine("-------------------------------------");

            List<ILogerService> logerServices = new List<ILogerService>() { filebaseLogerService, databaseLoggerService };
            basruruManager1.LoggerYap(logerServices);



        }
    }
}
