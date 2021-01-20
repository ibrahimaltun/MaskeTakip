using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EKLEME YÖNTEMİ 1
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2:Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500; //Lira/TL
            product1.UnitInStock = 3;

            //EKLEME YÖNTEMİ 2
            Product product2 = new Product {Id=2,CategoryId=2,
                UnitInStock = 5,ProductName="Kalem",UnitPrice=35};

            //PascalCase : Kelimelerin ilk harfi büyük yazılır.
            //productManager : CamelCase denir.
            //Pascal Case   //CamelCase
            //Case Sensitive : Küçük Büyük Harf Duyarlı
            ProductManager productManager = new ProductManager();
            //sol taraf stack(sitek)        //sağ taraf heap(hip)

            productManager.Add(product1);

        }
    }
}
