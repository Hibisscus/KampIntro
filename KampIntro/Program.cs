using System;


namespace KampIntro
{
    class Program
    {

        static void Main(string[] args)
        {

            string katagoriEtiketi = "KategoriCan";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.5;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 14.01;
            double dolarBugün = 14.01;


            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Artış");
            }
            else if (dolarDun < dolarBugün) 
            {
                Console.WriteLine("Azalış");
            }
            else
            {
                Console.WriteLine("Stabil");

            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Butonu"); 
            
            }
            else
            {
                Console.WriteLine("Giriş Butonu");
            }




            Console.WriteLine(faizOrani);

            Console.WriteLine(ogrenciSayisi);

            Console.WriteLine(katagoriEtiketi);

        }
    }
}