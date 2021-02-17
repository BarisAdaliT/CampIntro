using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convantion
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        } 

        public void Ekle2(string urunAdi, string aciklama, double fiyar, int stokAdeti)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
