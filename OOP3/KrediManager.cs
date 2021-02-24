using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bir çok farkı yerde aynı tür metodu(fonkiyon) kulanıcaksak eger bir şablon(interface) yaratırız ve kullanım kolaylıgı saglar 
    // bir bankada bir cok farklı kredi türü vardır ve her kredi kendi hesaplama sistemimine sahiptir aynı tür hesaplama işlemini her kredi türü için kulanamam 
    //2 tür yol var 1 hesaplama metodu yazıp içinde if lerle hangi kredi turunu ait oldugunu yazıcak (100 adet if else demek)
    //ya da bir interface(miras) yazarak hesapla metodu tanımlayıp bu metodu her kredi için kulana bilrizim içerigini geştirerek boylece if e gerek duymam ve kulanıcan aldıgım 
    //veriye göre direk hesaplama yaparım (iyi yazılım örnegidir)
    // interface genelikle iş(operasyonel metodlarda kullanılır)
    //bir birinin artanefi olan ama içerikleri farklı olan yerlerde kullanırız
    interface IKrediManager
    {
         void Hesapla();
        void BiseyYap();
        
    }
}
