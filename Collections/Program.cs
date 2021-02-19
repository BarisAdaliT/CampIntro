using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {   //coment=(cltr+k)+(cltr+c) uncoment(cltr+k)+(cltr+u)
            //tüm satırları seçmen lazım
            //string[] isimler = new string[] { "Barış", "Cem", "Deniz" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler[3] = "asadef"; //indexte 4 eleman için yer olmadıgından hata verir
            //Console.WriteLine(isimler[3]);

            //List<string> isimler2 = new List<string> (); (boş kullanım hali)
            List<string> isimler2 = new List<string> { "Barış", "Cem", "Deniz" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlayda");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
