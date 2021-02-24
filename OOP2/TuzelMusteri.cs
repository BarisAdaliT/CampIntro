using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //miras inheritance yani tuzel musteri benm bir müsterim sonuçta onu bir müsteri classında tutuyorum

    class TuzelMusteri :Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
