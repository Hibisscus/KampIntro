
using System;


namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdı = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 100;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdı = "java";
            kurs2.Eğitmen = "Tolga";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdı = "Python";
            kurs3.Eğitmen = "Mert";
            kurs3.IzlenmeOranı = 80;

            //onsole.WriteLine(kurs1.KursAdı + " : " + kurs1.Eğitmen);
                 //Takma ad
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };

                       //Takma ad
            foreach (var kurs in kurslar) //var hangi veri tipiyse o çalışır
            {
                Console.WriteLine(kurs.Eğitmen + " : " + kurs.IzlenmeOranı);    
            }
             

        }
    }
    //claslarda kendi veri tipimizi(like string,int,bool) yazıyomuş gibi düşünücez 
    class Kurs  //oluşturduğumuz kursu yukarda tanımladık like "Kurs kurs1 = newKurs();"    
    {
        public string KursAdı { get; set; }
        public string Eğitmen { get; set; }

        public int IzlenmeOranı { get; set; }

        
    }
}
