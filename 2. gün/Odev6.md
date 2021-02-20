# Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.
```c#
using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Bilgisayar";
            product1.Markasi = "lenovo";
            product1.Maaliyeti = 3999;

            Product product2 = new Product();
            product2.Adi = "Telefon";
            product2.Markasi = "Apple";
            product2.Maaliyeti = 3497;

            Product product3 = new Product();
            product3.Adi = "Kol Saati";
            product3.Markasi = "Apple";
            product3.Maaliyeti = 3799;

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Adi + " : " + products[i].Markasi + " : " + products[i].Maaliyeti);
            }
            Console.WriteLine("FOR BİTİİ");

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " : " + product.Markasi + " : " + product.Maaliyeti);
            }
            Console.WriteLine("FORECH BİTTİ");
        }
    }

    class Product
    {
        public string Adi { get; set; }
        public string Markasi { get; set; }
        public int Maaliyeti { get; set; }
    }
}
```
