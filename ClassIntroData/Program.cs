using System;

namespace ClassIntroData
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "barış";
            int yas = 22;
            
            
            
            //classları tanımladıktan sonra (class Kurs) degerlerini  
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyton";
            kurs3.Eğitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Eğitmen { get; set; }

        public int IzlenmeOrani { get; set; }

       

    }
}
