using System;  //Metodlar bizim için tekrar tekrar kullanılabilirliği sağlayan bir ortam sunar.


namespace Metods
{
    class Program
    {

        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Kivi";
            product1.Fiyati = 35;
            product1.Aciklama = "Çok hoş";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyati = 26;
            product2.Aciklama = "Kelek";

            Product[] Fruits = new Product[] { product1, product2 };

            foreach (Product productTakmaisim in Fruits)
            {
                Console.WriteLine(productTakmaisim.Id);
                Console.WriteLine(productTakmaisim.Adi);
                Console.WriteLine(productTakmaisim.Fiyati);
                Console.WriteLine(productTakmaisim.Aciklama);
                Console.WriteLine("-------------------------");

            }

            Console.WriteLine("------------Metodlar---------------");

            //instance  - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

        }
    }
}