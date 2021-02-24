using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    //miras inheritance yani gerçek müsterde benim bir müsterim sonuçta onu bir müsteri classında tutuyorum

    class GercekMüsteri :Musteri
    {
        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
