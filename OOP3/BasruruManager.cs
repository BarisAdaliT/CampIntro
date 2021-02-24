using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasruruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILogerService logerService)
        {
            //krediManager bir IKrediManager tipinde bir degişken 
            //IKrediManager içinde parklı farklı kredileri tutan bir yapı 
            //hangi türde veriyi gönderirsem o türde hesaplama yapar
            krediManager.Hesapla();
            logerService.Log();
        }

        public void KrediOnBiligilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        public void LoggerYap(List<ILogerService> Loglar)
        {
            foreach (var Log in Loglar)
            {
                Log.Log();
            }
        }
    }
}
