using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet --> hazır kodlar 
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        
        //stokfiyatı
        public double UnitPrice { get; set; }
        
        //stokmiktarı
        public int UnitInStock { get; set; }
        
        //CRUD : Create,Read,Update,Delete Operasyonları


    }
}
