
using System;


namespace Loops
{
    class Program
    {

        static void Main(string[] args)
        {
            string kurs1 = "Kişisel Gelişim";
            string kurs2 = "Beyinsel Gelişim";
            string kurs3 = "Body";

            //string[] Bu şekilde birden fazla değişkenni tutabilirz  yukarda sadece 1 değişken tutulur.

            string[] kurslar = new string[] { "Kişisel Gelişim", "Beyinsel Gelişim", "Body","Yeni Gelişim" };

              

            //1 den başla 10 dan küçük olduğu sürece çalış ve  bir bir arttır.
            for (int i = 0; i < kurslar.Length; i++) // i=i+2 iki iki arttırır. 
                              //kurslar.Length deişkenleri kendi sayar kaç tana varsa.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Döngüsü bittiği yer");

            foreach (string kurs in kurslar) //dizileri daha kolay dolaşırız.
            {
                Console.WriteLine (kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}


