using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //snippet
    class Product //entity - varlık
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans anahtarı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStok { get; set; }

        //CRUD
    }
}
